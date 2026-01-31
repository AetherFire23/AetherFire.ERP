## A client creates a new company

A user must exist inside a company. A user cannot be within two
different companies. Therefore, we need to create the organization AND the first user.
AND the user at the same time.

## Add a warehouse.
Simply add a warehouse

A warehouse belongs to a company

Add Products-Definition (definitions)
There are some product information. such as baseprice, etc.

Adjust inventory
A manager wants to modify stocks to the inventory without having to do a PurchaseOrder.
It is a Manual Adjustment. 

Difficulty : By default, there is no ProductItem in a warehouse.

If there is no ProductItem, create one.
there is only one way to create a ProductItem, 
by something setting the ProductItem quantity or creating it.

Encompassing Idea : Modify an Item quantity. 

-idea : could leave a logging or notification of that change for knowledge of what
affected the stocks. 
- idea : ItemAddedEvent()

PurchaseOrders
A buyer creates the purchase order.
Then he adds product lines to it and specifies the expected price.
He's issuing it to a Supplier; with an address, etc.

However I need to create a productOrder

Add a product to a warehouse  (reception of good)