int cambien = A0;
int giatri;
void setup() {                
  Serial.begin(9600);
  pinMode(cambien, INPUT);    
}
 
void loop() {
  giatri = analogRead(cambien);
  if(giatri < 150)
  {
      Serial.println("off");
  }else if(giatri > 900)
  {
      Serial.println("on");
  }
//  Serial.print("gia tri cam bien la : ");
//  Serial.println(giatri);
  delay(200);
}
