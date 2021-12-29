To whom it may concern...

To test this endpoint, you have several options.

1. Run the unit test.  This is how you should build endpoints, and anything without a user interface.  It is called test-driven-development.  And you should always have tests for your code.
2. Run the project.  Then use an api tool like Postman, for example, to send data and get responses.

The test project can be executed upon build...in Azure DevOps, for example.  It should fail the build if it fails.

There is also a resource group project, which is an ARM template which can also be executed during release to allocate or make changes to the host environment.

I do apologize that this is not building or finished, but I spent too much time and you should now have an idea of how I approach solution-building nonetheless.

Sean
