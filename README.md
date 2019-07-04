# Fluent Interface DB
This app performs an automated test to verify that the purchase of a product has been completed successfully.

  ### What is Selenium?
To answer I’ll quote directly from Selenium themselves:

  *Selenium automates browsers. That’s it! What you do with that power is entirely up to you. Primarily, it is for automating web applications for testing purposes, but is certainly not limited to just that. Boring web-based administration tasks can (and should!) be automated as well.*
  *Selenium has the support of some of the largest browser vendors who have taken (or are taking) steps to make Selenium a native part of their browser. It is also the core technology in countless other browser automation tools, APIs and frameworks.*

https://www.seleniumhq.org/

  ## Getting Started

To use this example we’ll need a few things

Don’t worry! They’re all free.

- Google Chrome Web Browser
- Visual Studio Code (or Community)
- .NET Core Framework 4.7.2

I’ll write this blog post using Visual Studio Code because it’s available for Windows, Mac & Linux but… if you’re on Windows, Visual Studio Community is my preferred IDE and I’d highly recommend it.

### Usage

Clone the GitHub repository below:
```
https://github.com/Jurley-Ribeiro/FluentInterfaceDB.git
```

In Visual Studio Community, we'll use the test configuration file that is in our repository:

```
Test > Test Settings > Select Test Settings File
```
Search for the `debug.runsettings` file in the repository.

 ### Tests Steps

After it’s done building we can now run the test. To run the test go ahead and click `Run Test` above `TestShop` and the test should:
  * Test case: make a successful purchase. 

  1. Open Chrome and access the website: www.automationpractice.com.

  2. Choose a product in the store: `Faded Short Sleeve T-shirts`.

  3. Add the chosen product in cart.

  4. Create a valid e-mail account (random).

  5. Validate if the product has been correctly added to the cart and continue if all is right.

  6. Make the customer's registration by filling in all the mandatory fields of the forms.

  7. Validate if the address is correct.

  8. Accept the terms of service.

  9. Validate the total purchase value: `$ 18.51`.

  10. Select the bank payment method.

  11. Confirm purchase and validate if successful.
  
  ## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
