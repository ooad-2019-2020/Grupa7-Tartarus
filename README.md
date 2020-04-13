# Correctional facility management system

## Team Tartarus
- [Hadžić Ajdin](https://github.com/Mordokh "Github") (Mordokh)
- [Mehmedović Faris](https://github.com/fmehmedovi1 "Github") (fmehmedovi1)
- [Halilović Kemal](https://github.com/KHalilovic3 "Github") (KHalilovic3)

## Opis teme
Upravljanje kazneno-popravnog zavoda je obimna odgovornost koja se sastoji od mnoštvo različitih procesa koji predstavljaju različite sfere sistema da se osigura društvo. Međutim, često zastarjela i kompleksna struktura sistema je podležna greškama koje stavljaju ovaj sistem u opasnost. Kako bi se izbjegle te greške tu dolazi Tartarus; softver zadužen za sferu kazneno-popravnog sistema za zatvorenike. Cilj ovog softvera je da olakša protok informacija između upravnika i čuvara, kao i drugih lica vezanih za zatvorenike; od onih koji žele da upute zahtjev za transfer zatvorenika do onih koji žele da posjete zatvorenike u kazneno-popravnom zavodu. Također je zadatak ovog softvera da olakša generalno upravljanje ali i nadzor zatvorenika u smislu vođenja evidencije o prisutnim zatvorenicima, njihovoj lokaciji kao i događanjima u kazneno-popravno zavodu koji se tiču njih, kao i čuvara i drugih zainteresovanih lica. 

## Funkcionalnosti
•	Kreacija, ažuriranje i brisanje korisničkog računa

•	Potreba i mogućnost da se generiše kod kako bi se novi korisnički račun otvorio

•	Kreacija, slanje i procesiranja zahtjeva

•	Komunikacija između korisnika u zavisnosti od nivoa pristupa korisničkog računa

•	Mogućnost postavljanja obavijesti koje su vidjljive samo određenim korisnicima

•	Mogućnost pretrage zatvorenika, kao i drugih korisnika

•	Mogućnost unosa i ažuriranja profila zatvorenika

•	Prikaz i ažuriranje specifikacija kazneno-popravnog zavoda

## Procesi

### Kreacija korisničkog računa:
Čuvari kao i lica sa suda koja započinju radni odnos kreiraju sebi račun, a upravnik ih odobrava

### Ažuriranje korisničkog računa:
Upravnik je u stanju da svim korisnicima u određenoj mjeri ažurira korisnički račun, dok svi korisnici mogu ažurirati svoj korisnički račun

### Brisanje korisničkog računa:
Upravnik je u stanju da svim korisnicima obriše korisnički račun, dok svi korisnici mogu sami svoj korisnički račun da obrišu

### Generisanje koda za otvaranje novog korisničkog računa:
Nakon potvrde zahtjeva za kreaciju korisničkog računa od strane upravnika, kod se generiše i šalje neregistrovanom korisniku, omogućavajući  mu kreaciju korisničkog računa

### Kreacija zahtjeva:
Korisnici (upravnik, čuvar, sud) kao i gosti imaju mogućnost kreacije zahtjeva

### Slanje zahtjeva:
Upravnik ima mogućnost da sudu šalje zahtjeve, dok sud, čuvari i gosti imaju mogućnost da upravniku šalju zahtjeve

### Procesiranje zahtjeva:
Korisnik koji je primio zahtjev ima mogućnost da ga odobri ili odbije uz mogućnost da napiše komentar vezan za svoju odluku

### Komunikacija između korisnika:
Korisnici su u stanju da jedan drugom šalju poruke u zavisnosti od toga koji je nivo pristupa njihovog korisničkog računa; tako da upravnik može komunicirati sa sudom i čuvarima dok sud može komunicirati samo sa upravnikom, a čuvari mogu komunicirati između sebe kao i sa upravnikom

### Postavljanje obavijesti:
Upravnik je u mogućnosti da kreira obavijesti koje će se u datom trenutku prikazati određenim korisnicima

### Pretraživanje:
Dok je upravnik u mogućnosti da pretražuje sve zatvorenike po određenim kriterijima kao i korisnike aplikacije, drugi korisnici mogu pretraživati samo u zavisnosti od nivoa pristupa njihovog korisničkog računa; tako da osobe iz suda mogu jedno i drugo pretraživati kao i zatvorenike iz bloka kojem imaju pristup

### Unos zatvorenika:
Upravnik je u stanju da unese nove zatvorenike u sistem

### Ažuriranje zatvorenika:
Upravnik je u stanju da u potpunosti ažurira podatke vezane za zatvorenika dok cu čuvari u mogućnosti da ostavljaju komentare na njihove profile

### Ažuriranje specifikacija kazneno-popravnog zavoda:
Upravnik ima sposobnost da ažurira specifikacije kazneno-popravnog zavoda kao što je kapacitet broja zatvorenika

## Akteri

•	Upravnik - Osoba zadužena za funkcionisanje čitavog kazneno-popravnog zavoda

•	Čuvar - Osoba zadužena za održavanje mira i sprovođenje sigurnosnih mjera u kazneno-popravnom zavodu

•	Sud - Osoba koja predstavlja interes suda ili sudskog procesa

•	Neregistrovani korisnik (Gost) - Osoba koja još nema registrovan račun na aplikaciji

