# DockerDemo
Mjølner Docker Demo  

Game rules:  
Vær person nr. 100 der poker https://mjolnerdockerdemo.azurewebsites.net/  
Der er selvfølgelig et par barrikadere, for at forhindre at der sendes 100 pokes på én gang.  
Der skal ændres en lille smule i programmet for at få det til at poke korrekt... :)  
Serveren bør fortælle hvad der skal gøres hvis der pokes forkert.  


Run  
docker build . -f Dockerfile -t docker-demo-container  
docker run docker-demo-container  
