#include <DHT.h>
#include <LiquidCrystal.h>

LiquidCrystal lcd(7,6,5,4,3,2);

const int DHTPIN = 8;
const int DHTTYPE = DHT11;
DHT dht(DHTPIN, DHTTYPE);

byte degree[8] = 
{
  0B01110,
  0B01010,
  0B01110,
  0B00000,
  0B00000,
  0B00000,
  0B00000,
  0B00000
};

void setup() 
{
  Serial.begin(9600);
  lcd.begin(16,2);
  lcd.print("Nhiet do: ");
  lcd.setCursor(0,1);
  lcd.print("Do am: ");
  
  lcd.createChar(1, degree);
  
  dht.begin();  
}

void loop()
{
  int h = dht.readHumidity();
  int t = dht.readTemperature();

  if (isnan(t) || isnan(h)) {} // Kiểm tra xem thử việc đọc giá trị có bị thất bại hay không. Hàm isnan bạn xem tại đây http://arduino.vn/reference/isnan 
  else 
  {
    lcd.setCursor(10,0);
    lcd.print(round(t));
    lcd.print(" ");
    lcd.write(1);
    lcd.print("C");
    
    lcd.setCursor(10,1);
    lcd.print(round(h));
    lcd.print(" %");
    //Serial.print("Nhiệt độ: ");
    Serial.println(t);
    delay(1000);
    //Serial.print("Độ ẩm: ");
    //Serial.println(h);
    //delay(1000);   
  }
}
