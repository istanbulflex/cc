int ledPinleri[] = {2, 3, 4, 5, 6, 7, 8};
int ledSayisi = 7;

void setup() {
  for (int i = 0; i < ledSayisi; i = i + 1) {
    pinMode(ledPinleri[i], OUTPUT);
  }
}

void loop() {
  for (int i = 0; i < ledSayisi; i = i + 1) {
    digitalWrite(ledPinleri[i], HIGH);
  }
  delay(750);
  
  for (int i = 0; i < ledSayisi; i = i + 1) {
    digitalWrite(ledPinleri[i], LOW);
  }
  delay(750);
}
