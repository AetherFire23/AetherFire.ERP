## A client creates a new company

A user must exist inside a company. A user cannot be within two
different companies. Therefore, we need to create the organization AND the first user.
AND the user at the same time.

sub-users, that are not admin, cannot register by themselves.
They must be added by the main user. 

## Add a warehouse.

An admin adds a new warehouse.

## Add product-definition

Add Products-Definition (definitions)
There are some product information. such as lastprice, etc.

## Adjust inventory
A manager wants to modify stocks to a productItem

Difficulty : By default, there is no ProductItem in a warehouse.
A productItem is an item quantity for a warehouse. 

If there is no ProductItem, create one.

## PurchaseOrders
A buyer creates the purchase order.
Then he adds product lines to it and specifies the expected price.
He's issuing it to a Supplier; with an address, etc.

However I need to create a productOrder

Add a product to a warehouse  (reception of good)