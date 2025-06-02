
---

# Single Responsibility Principle (SRP) Examples in C#

Welcome to this repository containing 50 practical examples to illustrate the **Single Responsibility Principle (SRP)** using the C# programming language. This repository aims to help developers understand how to apply SRP correctly and avoid violations, leading to more maintainable and scalable code.

## What is the Single Responsibility Principle?
The Single Responsibility Principle is one of the **SOLID** principles in software design. It states that a class should have only one responsibility, meaning it should have only one reason to change. This principle reduces complexity and improves code reusability.

### Illustrative Example
- **SRP Violation**: A class that manages user data and sends emails simultaneously.
- **SRP Adherence**: Separating user data management into one class and email sending into another.

## Repository Contents
The repository contains 50 examples, each including:
1. **SRP Violation**: A single class handling multiple responsibilities, violating the principle.
2. **SRP Adherence**: Responsibilities separated into independent classes, each with a single responsibility.

### Repository Structure
- The `Examples` folder contains 50 subfolders (Example1 to Example50).
- Each subfolder contains two files:
  - A file violating SRP (e.g., `UserManagerViolate.cs`).
  - A file adhering to SRP (e.g., `UserManager.cs`).
- The `SRP-Examples.sln` solution file for running the project in Visual Studio.
- The `LICENSE` file containing the MIT License.

## List of Examples
| Example | Description | Violation File | Adherence File |
|---------|-------------|----------------|----------------|
| 1 | User Management and Email Sending | [UserManagerViolate.cs](Examples/Example1/UserManagerViolate.cs) | [UserManager.cs](Examples/Example1/UserManager.cs) |
| 2 | Order Processing and Logging | [OrderProcessorViolate.cs](Examples/Example2/OrderProcessorViolate.cs) | [OrderProcessor.cs](Examples/Example2/OrderProcessor.cs) |
| 3 | Employee Data and Payroll Calculation | [EmployeeViolate.cs](Examples/Example3/EmployeeViolate.cs) | [Employee.cs](Examples/Example3/Employee.cs) |
| 4 | Product Management and Discount Application | [ProductViolate.cs](Examples/Example4/ProductViolate.cs) | [Product.cs](Examples/Example4/Product.cs) |
| 5 | Invoice Generation and PDF Export | [InvoiceViolate.cs](Examples/Example5/InvoiceViolate.cs) | [Invoice.cs](Examples/Example5/Invoice.cs) |
| 6 | Customer Management and Notification | [CustomerViolate.cs](Examples/Example6/CustomerViolate.cs) | [Customer.cs](Examples/Example6/Customer.cs) |
| 7 | Payment Processing and Receipt Generation | [PaymentProcessorViolate.cs](Examples/Example7/PaymentProcessorViolate.cs) | [PaymentProcessor.cs](Examples/Example7/PaymentProcessor.cs) |
| 8 | Book Management and Review System | [BookViolate.cs](Examples/Example8/BookViolate.cs) | [Book.cs](Examples/Example8/Book.cs) |
| 9 | Shopping Cart and Tax Calculation | [ShoppingCartViolate.cs](Examples/Example9/ShoppingCartViolate.cs) | [ShoppingCart.cs](Examples/Example9/ShoppingCart.cs) |
| 10 | File Management and Compression | [FileManagerViolate.cs](Examples/Example10/FileManagerViolate.cs) | [FileManager.cs](Examples/Example10/FileManager.cs) |
| 11 | Order Validation and Email Notification | [OrderViolate.cs](Examples/Example11/OrderViolate.cs) | [Order.cs](Examples/Example11/Order.cs) |
| 12 | User Authentication and Logging | [UserAuthenticatorViolate.cs](Examples/Example12/UserAuthenticatorViolate.cs) | [UserAuthenticator.cs](Examples/Example12/UserAuthenticator.cs) |
| 13 | Report Generation and Formatting | [ReportViolate.cs](Examples/Example13/ReportViolate.cs) | [Report.cs](Examples/Example13/Report.cs) |
| 14 | Product Inventory and Pricing | [ProductInventoryViolate.cs](Examples/Example14/ProductInventoryViolate.cs) | [ProductInventory.cs](Examples/Example14/ProductInventory.cs) |
| 15 | Customer Support and Ticket Logging | [SupportAgentViolate.cs](Examples/Example15/SupportAgentViolate.cs) | [SupportAgent.cs](Examples/Example15/SupportAgent.cs) |
| 16 | Order Fulfillment and Shipping | [OrderFulfillmentViolate.cs](Examples/Example16/OrderFulfillmentViolate.cs) | [OrderFulfillment.cs](Examples/Example16/OrderFulfillment.cs) |
| 17 | User Profile and Data Export | [UserProfileViolate.cs](Examples/Example17/UserProfileViolate.cs) | [UserProfile.cs](Examples/Example17/UserProfile.cs) |
| 18 | Payment Validation and Notification | [PaymentViolate.cs](Examples/Example18/PaymentViolate.cs) | [Payment.cs](Examples/Example18/Payment.cs) |
| 19 | Inventory Management and Reporting | [InventoryViolate.cs](Examples/Example19/InventoryViolate.cs) | [Inventory.cs](Examples/Example19/Inventory.cs) |
| 20 | Event Management and Logging | [EventViolate.cs](Examples/Example20/EventViolate.cs) | [Event.cs](Examples/Example20/Event.cs) |
| 21 | Customer Data and Analytics | [CustomerAnalyticsViolate.cs](Examples/Example21/CustomerAnalyticsViolate.cs) | [CustomerAnalytics.cs](Examples/Example21/CustomerAnalytics.cs) |
| 22 | Order Tracking and Notification | [OrderTrackingViolate.cs](Examples/Example22/OrderTrackingViolate.cs) | [OrderTracking.cs](Examples/Example22/OrderTracking.cs) |
| 23 | File Parsing and Validation | [FileParserViolate.cs](Examples/Example23/FileParserViolate.cs) | [FileParser.cs](Examples/Example23/FileParser.cs) |
| 24 | Product Catalog and Search | [ProductCatalogViolate.cs](Examples/Example24/ProductCatalogViolate.cs) | [ProductCatalog.cs](Examples/Example24/ProductCatalog.cs) |
| 25 | User Registration and Validation | [UserRegistrationViolate.cs](Examples/Example25/UserRegistrationViolate.cs) | [UserRegistration.cs](Examples/Example25/UserRegistration.cs) |
| 26 | Order History and Reporting | [OrderHistoryViolate.cs](Examples/Example26/OrderHistoryViolate.cs) | [OrderHistory.cs](Examples/Example26/OrderHistory.cs) |
| 27 | Payment Gateway and Logging | [PaymentGatewayViolate.cs](Examples/Example27/PaymentGatewayViolate.cs) | [PaymentGateway.cs](Examples/Example27/PaymentGateway.cs) |
| 28 | Customer Feedback and Analysis | [FeedbackViolate.cs](Examples/Example28/FeedbackViolate.cs) | [Feedback.cs](Examples/Example28/Feedback.cs) |
| 29 | Product Review and Notification | [ProductReviewViolate.cs](Examples/Example29/ProductReviewViolate.cs) | [ProductReview.cs](Examples/Example29/ProductReview.cs) |
| 30 | User Session and Logging | [UserSessionViolate.cs](Examples/Example30/UserSessionViolate.cs) | [UserSession.cs](Examples/Example30/UserSession.cs) |
| 31 | Order Discount and Validation | [OrderDiscountViolate.cs](Examples/Example31/OrderDiscountViolate.cs) | [OrderDiscount.cs](Examples/Example31/OrderDiscount.cs) |
| 32 | File Storage and Encryption | [FileStorageViolate.cs](Examples/Example32/FileStorageViolate.cs) | [FileStorage.cs](Examples/Example32/FileStorage.cs) |
| 33 | Customer Orders and Billing | [CustomerOrdersViolate.cs](Examples/Example33/CustomerOrdersViolate.cs) | [CustomerOrders.cs](Examples/Example33/CustomerOrders.cs) |
| 34 | Product Pricing and Tax | [ProductPricingViolate.cs](Examples/Example34/ProductPricingViolate.cs) | [ProductPricing.cs](Examples/Example34/ProductPricing.cs) |
| 35 | User Profile and Backup | [UserProfileBackupViolate.cs](Examples/Example35/UserProfileBackupViolate.cs) | [UserProfileBackup.cs](Examples/Example35/UserProfileBackup.cs) |
| 36 | Order Processing and Inventory Update | [OrderProcessorInventoryViolate.cs](Examples/Example36/OrderProcessorInventoryViolate.cs) | [OrderProcessorInventory.cs](Examples/Example36/OrderProcessorInventory.cs) |
| 37 | Customer Support and Email | [SupportTicketViolate.cs](Examples/Example37/SupportTicketViolate.cs) | [SupportTicket.cs](Examples/Example37/SupportTicket.cs) |
| 38 | Product Data and Export | [ProductExportViolate.cs](Examples/Example38/ProductExportViolate.cs) | [ProductExport.cs](Examples/Example38/ProductExport.cs) |
| 39 | User Permissions and Logging | [UserPermissionsViolate.cs](Examples/Example39/UserPermissionsViolate.cs) | [UserPermissions.cs](Examples/Example39/UserPermissions.cs) |
| 40 | Order Payment and Receipt | [OrderPaymentViolate.cs](Examples/Example40/OrderPaymentViolate.cs) | [OrderPayment.cs](Examples/Example40/OrderPayment.cs) |
| 41 | Customer Data and Validation | [CustomerValidationViolate.cs](Examples/Example41/CustomerValidationViolate.cs) | [CustomerValidation.cs](Examples/Example41/CustomerValidation.cs) |
| 42 | Product Reviews and Moderation | [ProductReviewModerationViolate.cs](Examples/Example42/ProductReviewModerationViolate.cs) | [ProductReviewModeration.cs](Examples/Example42/ProductReviewModeration.cs) |
| 43 | User Data and Encryption | [UserEncryptionViolate.cs](Examples/Example43/UserEncryptionViolate.cs) | [UserEncryption.cs](Examples/Example43/UserEncryption.cs) |
| 44 | Order Delivery and Tracking | [OrderDeliveryViolate.cs](Examples/Example44/OrderDeliveryViolate.cs) | [OrderDelivery.cs](Examples/Example44/OrderDelivery.cs) |
| 45 | Customer Feedback and Notification | [FeedbackNotificationViolate.cs](Examples/Example45/FeedbackNotificationViolate.cs) | [FeedbackNotification.cs](Examples/Example45/FeedbackNotification.cs) |
| 46 | Product Catalog and Pricing | [ProductCatalogPricingViolate.cs](Examples/Example46/ProductCatalogPricingViolate.cs) | [ProductCatalogPricing.cs](Examples/Example46/ProductCatalogPricing.cs) |
| 47 | User Authentication and Session Management | [UserAuthSessionViolate.cs](Examples/Example47/UserAuthSessionViolate.cs) | [UserAuthSession.cs](Examples/Example47/UserAuthSession.cs) |
| 48 | Order Confirmation and Email | [OrderConfirmationViolate.cs](Examples/Example48/OrderConfirmationViolate.cs) | [OrderConfirmation.cs](Examples/Example48/OrderConfirmation.cs) |
| 49 | Product Stock and Notification | [ProductStockViolate.cs](Examples/Example49/ProductStockViolate.cs) | [ProductStock.cs](Examples/Example49/ProductStock.cs) |
| 50 | Customer Data and Reporting | [CustomerReportingViolate.cs](Examples/Example50/CustomerReportingViolate.cs) | [CustomerReporting.cs](Examples/Example50/CustomerReporting.cs) |

## How to Run the Examples
1. **Requirements**:
   - Install **Visual Studio** (or any IDE supporting C#).
   - .NET Framework (preferably .NET 6.0 or later).
2. **Steps**:
   - Clone the repository:
     ```bash
     git clone https://github.com/YourUsername/SRP-Examples-CSharp.git
     ```
   - Open the solution file `SRP-Examples.sln` in Visual Studio.
   - Navigate to the `Examples` folder to select the desired example.
   - To run a specific example, add a `Program.cs` file to test the classes or run the code directly.
3. **Example Run (for Example 1)**:
   ```csharp
   using System;
   namespace SRP_Examples
   {
       class Program
       {
           static void Main(string[] args)
           {
               // Violation
               var userManagerViolate = new Example1.UserManager();
               userManagerViolate.CreateUser("Ali", "ali@example.com");

               // Adherence
               var userManager = new Example1.UserManager();
               var emailService = new Example1.EmailService();
               userManager.CreateUser("Ali", "ali@example.com");
               emailService.SendWelcomeEmail("ali@example.com");
           }
       }
   }
   ```

## License
This project is licensed under the [MIT License](LICENSE).

## Contributing
- If you’d like to add new examples or improve the repository:
  1. Create a new branch (`git checkout -b feature-branch`).
  2. Commit your changes (`git commit -m "Add new example"`).
  3. Create a Pull Request via GitHub.
- You can also open an Issue to suggest improvements or report bugs.

## Acknowledgments
Thank you for your interest in learning software design principles! If you have any questions, feel free to open an Issue or contact via GitHub.
