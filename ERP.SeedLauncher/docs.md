# Scenarios

## the problem it's solving

A seed is a set of data implanted on the backend. It consist of test data or always-present seed data.

A Test is verifying if an action did have the intended consequences. and what result is expected.

An E2E test uses a browser to simulate user actions, and verifies the integrity of the whole process.

However when developing web apps we often need a
middle-ground between a data test and an e2e test without mocking an api but also without simulating a million clicks.

1. Testing frontend components is long, tedious, and requires serious framework understanding
2. Therefore, some trivial changes to frontend become hard to test
3. Some tests are easier to write and reason after some prototyping is done.
4. Initial seed data is far from

In my view, a scenario chains sequences of use-cases as initial seed data and then allows a visualization through the browser.

However, when developing web apps we often need a
middle-ground between a data test and an e2e test without mocking an api but also without simulating a million clicks.

## what is allows to do :

1. Seed backend data preferable through valid use-cases
2. Start a playwright browser and visualize changes to the frontend.

That`s it. 

It allows simple prototyping all the while 

## How

Define two new assemblies. One assembly contain seed data (can be reused by tests or production)

Seed data have clases inheriting the ISeeder Interface

The web application now understand the --scenario 



