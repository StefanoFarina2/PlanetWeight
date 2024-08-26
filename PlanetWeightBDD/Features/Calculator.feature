Feature: Planet Weight Calculator
    In order to understand how weight changes on different planets
    As a user
    I want to calculate my weight on various planets in the solar system

Scenario: Calculate weight on Earth
    Given I weigh '70' kilograms on Earth
    When I calculate my weight on Earth
    Then my weight on Earth should be '70' kilograms

Scenario: Calculate weight on Mars
    Given I weigh '70' kilograms on Earth
    When I calculate my weight on Mars
    Then my weight on Mars should be '26.4' kilograms

Scenario: Calculate weight on Jupiter
    Given I weigh '70' kilograms on Earth
    When I calculate my weight on Jupiter
    Then my weight on Jupiter should be '165.48' kilograms
