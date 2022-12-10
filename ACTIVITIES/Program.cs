// Activity: Using arithmetic operators.
int a = 15;
int b = 3;
int c = a - b;
int d = c / b;
int e = d * a;
Console.WriteLine(e);

// Ask user for value.
Console.WriteLine("Please enter hourly rate.");
// Take value and store in hourlyRate.
double hourlyRate = Convert.ToDouble(Console.ReadLine());
// Ask user for value.
Console.WriteLine("Please enter the hours worked.");
// Take value and store in hoursWorked.
double hoursWorked = Convert.ToDouble(Console.ReadLine());
// Calculate value to return to user.
double grossPay = hourlyRate * hoursWorked;
// Return value to user through output stream.
Console.WriteLine("$" + grossPay + " gross pay earned.");