#include <18F4550.h>
#device adc=8       //Resolucion 8BITS
#use delay(clock=10000000)    //Oscilador de 10Mz
#use rs232(baud=9600, xmit=PIN_C6,rcv=PIN_C7,bits=8,parity=N)  // Configuracion de la comunicacion serial
#fuses HS,NOPROTECT,NOWDT,NOLVP,CPUDIV1,nomclr     // Configuracion de los Fuses

#use FAST_IO(A) 
#use FAST_IO(B)
#use FAST_IO(D)

// Definicion de direcciones en la memoria del PIC
#byte T0CON=0xFD5
#byte wreg=0xFE8
#byte TOSU=0xFFF
#byte TOSH=0xFFE
#byte TOSL=0xFFD

// Declaracion de Variables

char  rcvchar=0x00;


// Interrupcion por comunicacion serial
#INT_RDA
void serial_isr()
{
   //printf("Recibido");     // se envia por Serial una palabra para verificar interrupcion
   rcvchar = 0x00;
   rcvchar = getc();    // se recibe el caracter enviado por la computadora
   printf("%c", rcvchar );
   delay_us(20);
}

void main()
{

   while(TRUE)
   {
      //TODO: User Code
   }

}
