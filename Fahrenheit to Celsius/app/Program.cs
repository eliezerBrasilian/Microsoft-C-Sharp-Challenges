int fahrenheit = 94;

decimal fahrenheitToCelsius = (fahrenheit - 32)* (5/(decimal)9);

int leadingDigit = (int)fahrenheitToCelsius;
int trailingDigits = (int)(fahrenheitToCelsius * 100) - ( leadingDigit * 100);
Console.WriteLine($"The temperature is {leadingDigit}.{trailingDigits} Celsius.");