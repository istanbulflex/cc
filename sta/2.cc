void setup() {
  // Rastgele sayı üretecini başlat
  randomSeed(analogRead(0));

  // 2'den 8'e kadar olan tüm pinleri çıkış yap
  for (int pin = 2; pin <= 8; pin++) {
    pinMode(pin, OUTPUT);
  }
}

void loop() {
  // 2 ile 8 arasında rastgele bir pin seç (8 dahil olsun diye 9 yazılır)
  int rastgelePin = random(2, 9);

  digitalWrite(rastgelePin, HIGH); // Seçilen LED'i yak
  delay(500);                      // 0.5 saniye bekle
  digitalWrite(rastgelePin, LOW);  // LED'i söndür
  delay(200);                      // Bekle ve başa dön
}
