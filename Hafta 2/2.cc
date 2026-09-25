int ledPins[] = {2, 3, 4, 5, 6};
int ledCount = 5;
int delayTime = 500;
  
void setup()
{
  for (int i = 0; i < ledCount; i++)
  {
    pinMode(ledPins[i], OUTPUT);
  }
}

void loop()
{
  for (int i = 0; i < ledCount; i++)
  {
    if (i % 2 != 0) { 
      digitalWrite(ledPins[i], HIGH);
    }
  }
  delay(delayTime);

  for (int i = 0; i < ledCount; i++)
  {
    if (i % 2 != 0) {
      digitalWrite(ledPins[i], LOW);
    }
  }
  delay(delayTime);

  for (int i = 0; i < ledCount; i++)
  {
    if (i % 2 == 0) {
      digitalWrite(ledPins[i], HIGH);
    }
  }
  delay(delayTime);

  for (int i = 0; i < ledCount; i++)
  {
    if (i % 2 == 0) {
      digitalWrite(ledPins[i], LOW);
    }
  }
  delay(delayTime);
}
