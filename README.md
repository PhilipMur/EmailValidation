# EmailValidation
Csharp C# Email Validaton offline


A very easy to use C# class in any project.

This project contains a class called ***"ValidateEmailUtility.cs"***, Use this to recreate this class in your own project.

This project comes with a test form to import sample emails via CSV format (charater serperated values) or text format,
#### (see samples. EmailAddressesBad.txt and EmailAddressesGood.txt)

Verifies against good samples and bad samples over the last while to detect misspelled email domains (gmail , hotmail etc..) and TLD (com , ie etc...)

This will do 2 things stop email bounces which is bad for our email reputation and stop people from accidentally entering the wrong information so that they can get the email 
and don't blame the system for not sending it.

## USAGE:

`bool isValid = validateEmail.ValidateEmailAddress("user@gmail.com");`


Test Files can be imported for testing GOOD and BAD email address to verify it works.

Please if you find something wrong post here so we can all benefit thanks.
