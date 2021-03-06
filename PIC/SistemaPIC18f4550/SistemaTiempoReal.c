#include <18F4550.h>
#device adc=8       //Resolucion 8BITS
#use delay(clock=10000000)    //Oscilador de 10Mz
#use rs232(baud=9600, xmit=PIN_C6,rcv=PIN_C7,bits=8,parity=N)  // Configuracion de la comunicacion serial
#fuses HS,NOPROTECT,NOWDT,NOLVP,CPUDIV1,nomclr     // Configuracion de los Fuses

#use FAST_IO(A) 
#use FAST_IO(B)
#use FAST_IO(D)

// Declaracion de Variables
char  rcvchar=0x00;
int1  flagcmd=0;


void inte_Init()  // interrupcion de puerto serial
{
   enable_interrupts(GLOBAL);
   enable_interrupts(INT_RDA);
}

// Interrupcion por comunicacion serial
#INT_RDA
void serial_isr()
{
   //printf("Recibido");     // se envia por Serial una palabra para verificar interrupcion
   rcvchar = 0x00;
   rcvchar = getc();    // se recibe el caracter enviado por la computadora
   output_toggle(PIN_D6);
   flagcmd=1;
   //printf("%c", rcvchar );
   //delay_us(20);
}

void procesa_cmd(void){             // procesa el ultimo comando guardado, un comando esta comprendido entre $ hasta * 
 
   disable_interrupts(int_rda);     
   flagcmd=0;                       // Desactivo flag de comando pendiente.
   //printf("Recibido");
   printf("%c", rcvchar );
   enable_interrupts(int_rda);            
}


void Port_Init()
{
   set_tris_b(0x00);
   set_tris_d(0x00);
   set_tris_a(0x00);
   output_b(0x00);
   output_d(0x00);
   output_a(0x00);
}




void MCU_Init()
{
   printf("Conectado....*");
   Port_Init();
   inte_Init();
}


void main()
{
   MCU_Init();   
   while(TRUE)
   {  
      if(flagcmd){
         procesa_cmd();
      }

   }

}
