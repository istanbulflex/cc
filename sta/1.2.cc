int ledPinleri[] = {2, 3, 4, 5, 6, 7, 8};
int ledSayisi = 7;

void setup() {
  int i = 0; // Sayacı sıfırla
  while (i < ledSayisi) {
    pinMode(ledPinleri[i], OUTPUT);
    i++; // i değerini 1 artır
  }
}

void loop() {
  int i = 0; // Her tur başında sayacı sıfırla

  // Tüm LED'leri yak
  while (i < ledSayisi) {
    digitalWrite(ledPinleri[i], HIGH);
    i++;
  }
  delay(750);

  i = 0; // Söndürme işlemi için sayacı tekrar sıfırla

  // Tüm LED'leri söndür
  while (i < ledSayisi) {
    digitalWrite(ledPinleri[i], LOW);
    i++;
  }
  delay(750);
}
