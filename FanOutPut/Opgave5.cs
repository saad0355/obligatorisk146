using System;
using System.Collections.Generic;
using System.Text;

namespace FanOutPut2
{
    class Opgave5
    {

        //HTTP står for HyperText Transfer Protocol og S står for “Secure”. 
        //HTTP bruges hovedsageligt til kommunikation på World Wide Web(WWW). 
        //På vegne af en browser beder HTTP, der er en protokol, en server om specifikke data.
        //Derefter svarer serveren så med en protokolkode og dataen.
        //Dette kan være et HTML-dokument, et billede eller en fejlkode.
        //På denne måde kan browseren bygge siden op med de data, som den har modtaget fra serveren.

        //1.request og response 
        //Hvordan data udveksles mellem en server og en klient.
        //Der er to typer meddelelser: anmodninger sendt af klienten for at udløse en handling på serveren,
        //og svar , svaret fra serveren.

        //2.Methods
        //Beskriver den handling, der skal udføres
        //GET, PUT, POST, DELETE Eller PATCH

        //GET Angiver for eksempel, at en ressource skal hentes

        //POST betyder, at data skubbes til serveren
        //POST metoden er ikke identisk, hvis vi sender den samme POST anmodning flere gange, 
        //vil vi modtage forskellige resultater

        //PUT metode erstatter helt hvad øjeblikket eksisterer på målet/objeket med noget andet.
        // Med denne metode kan du oprette en ny ressource eller overskrive en eksisterende, 
        //forudsat at du kender den nøjagtige Request-URI 
        //uanset hvor mange gange vi sender den samme anmodning, vil resultaterne altid være de samme.

        //DELETE metoden bruges til at slette data.

        //PATCH bruges til ændre -funktioner.PATCH-anmodningen behøver kun at indeholde ændringerne til ressourcen,
        //ikke den komplette ressource.


        //3. Status koder og messages
        //HTTP-responsstatuskoder angiver om en specifik HTTP- anmodning er udført
        //Svarene har som regelt hver deres kode og med tilhørende tekst
        //Eksempel : //Not found(code 404) //Klientfejl(code 4xx)  //serverfejl (code 500)
    }
}
