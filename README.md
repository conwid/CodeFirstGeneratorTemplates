# Entity Framework Code First Migration SQL generator and C# scaffolder

A not very-well known, but very useful feature of Entity Framework Code First is the ability to add your custom sql generators that are used when you create sql scripts from your migrations and to add your custom code generators that are used when C# code is created from your migrations. 

I have used custom generators in some of my projects as well, but since this is not a very well known and widely used feature, finding the corresponding documentation takes some time :) So I thought I would create a Visual Studio extension that has an item template for a custom sql generator and a custom C# code generator.

[After downloading the extension from the marketplace](), you have the option to add a "Custom migration code generator" to the project:

This adds a nice little class with the required boilerplate and some comments to help you get started:

You can also add a "Custom migration sql generator" to the project:

Again, this adds a class with the required boilerplate and some comments:

## Contribution

Ideas are welcome; create an issue or submit a PR if you have something.
