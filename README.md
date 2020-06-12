# DockerDemo
Mjølner Docker Demo  

Game rules:  
Vær person nr. 100 der poker https://mjolnerdockerdemo.azurewebsites.net/  
Der er selvfølgelig et par barrikadere, for at forhindre at der sendes 100 pokes på én gang.  
Der skal ændres en lille smule i programmet for at få det til at poke korrekt... :)  
Serveren bør fortælle hvad der skal gøres hvis der pokes forkert.  

What to do:
1) Install docker : https://www.docker.com/get-started
2) Skift til at bruge Linux containers (højre klik på tray docker ikonet og vælg Switch to Linux containers)
3) Download DockerDemo
4) Udpak DockerDemo og start en commando prompt i folderen hvor DockerDemo er udpakket

Kør
5) docker build . -f Dockerfile -t docker-demo-container  
6) docker run docker-demo-container 
7) Observe errors
8) fix fejl ved at redigere program.cs
9) goto 5
