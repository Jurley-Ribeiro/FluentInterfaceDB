# FluentInterfaceDB

What is Selenium?
To answer I’ll quote directly from Selenium themselves:

  Selenium automates browsers. That’s it! What you do with that power is entirely up to you. Primarily, it is for automating web applications for testing purposes, but is certainly not limited to just that. Boring web-based administration tasks can (and should!) be automated as well.
  Selenium has the support of some of the largest browser vendors who have taken (or are taking) steps to make Selenium a native part of their browser. It is also the core technology in countless other browser automation tools, APIs and frameworks.

https://www.seleniumhq.org/

Getting Started

To use this example we’ll need a few things

Don’t worry! They’re all free.

- Google Chrome Web Browser
- Visual Studio Code (or Community)
- DotNetCore 2.1
I’ll write this blog post using Visual Studio Code because it’s available for Windows, Mac & Linux but… if you’re on Windows, Visual Studio Community is my preferred IDE and I’d highly recommend it.

In Visual Studio Code we’ll use the hotkey:
`CTRL + SHIFT + P`

This will pull up the command window where we can type:
`Git Clone`

Once you see the clone option go ahead and hit ‘Enter’ and paste in the url below for the GitHub repository.
`git-----`

After it’s done building we can now run the test. To run the test go ahead and click `Run Test` above EscreverNomeDoTeste() and the test should:
  * Open Chrome
  * Go to www.automationpractice.com
  * Add product (DEFINE PRODUCT NAME) in cart
