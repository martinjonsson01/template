Feature: Greeter
Great tool for greeting the user.

Link to a feature: [Calculator]($projectname$/Features/Calculator.feature)

    @mytag
    Scenario: Greet noone
    Greet without specifying who to greet
        When greeting
        Then the text should be "Hello there!"

    Scenario: Greet user
    Greet specific people
        Given the user's name is <Name>

        When greeting
        Then the text should be "Hello, <Name>!"

    Examples:
      | Name   |
      | Jonas  |
      | Lars   |
      | Bertil |
