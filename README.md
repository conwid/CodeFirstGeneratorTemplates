# Entity Framework Code First Migration SQL generator and C# scaffolder

A not very-well known, but very useful feature of Entity Framework Code First is the ability to add your custom sql generators that are used when you create sql scripts from your migrations and to add your custom code generators that are used when C# code is created from your migrations. 

I have used custom generators in some of my projects as well, but since this is not a very well known and widely used feature, finding the corresponding documentation takes some time :) So I thought I would create a Visual Studio extension that has an item template for a custom sql generator and a custom C# code generator.

[After downloading the extension from the marketplace](), you have the option to add a "Custom migration code generator" or a "Custom migration sql generator" to the project:

![](https://dotnetfalconcontent.blob.core.windows.net/entity-framework-code-first-generator-templates/addnewitems.png)

The generator items add nice little classes with the required boilerplate and some comments to help you get started:

![](https://dotnetfalconcontent.blob.core.windows.net/entity-framework-code-first-generator-templates/codegenerator.png)

![](https://dotnetfalconcontent.blob.core.windows.net/entity-framework-code-first-generator-templates/sqlgenerator.png)

## Contribution

Ideas are welcome; create an issue or submit a PR if you have something.
