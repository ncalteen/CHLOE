# Level Description

Introduces players to unstructured data storage using Amazon DynamoDB. The context of this activity is focused around using NoSQL tables to store and transform data found during administrative investigations.

## Objective

Players will create a table, enter sample data, query the table, and finally delete the created resource(s).

```plain
"The admins are going through the logs now, but will need somewhere to store critical information. Maybe you can set something up for them to drop data into?"
```

## Level Tasks/Goals

1. *"First off, try creating an Amazon DynamoDB table. The admins can put whatever data they would like in there, it should be a good fit."*
    - The player must create an Amazon DynamoDB table.
1. "That should work...can you try loading some data into the table?"
    - The player must load data into the table.
1. *"What does it look like if you try to pull data from the table?"*
    - The player must query the table for a specific item.
1. *"Can you just dump the table contents at once?"*
    - The player must scan the table.
1. *"Ok, looks good to me, boss. We should clean this table up for now though. I'll send the admins an email with instructions on how to set one up with the indexes they need."*
    - The player must delete the Amazon DynamoDB table.
