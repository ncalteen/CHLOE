# IAM Level

Introduces players to permissions control using AWS Identity and Access Management (IAM). The context of this activity is focused around giving administrators proper permissions to perform debugging/log-diving to determine the player's situation and provide next steps to resolve the player's predicament.

## Objective

Introduce players to IAM permissions management, user creation, group management, etc. The player will inspect IAM policies, create/edit groups, add users to groups, and other activities that mirror real-world scenarios.

```plain
Ok, now that you're comfortable working here, it's time to get the admins into the system. They're going to need accounts and permissions before they'll be able to do anything. Can you set up policies, groups, and users?
```

## Level Tasks/Goals

1. *"I think I was able to create some user accounts before my keys were disabled. Can you look around and see if you can find them?*
    - The player must find and inspect several IAM user resources.
1. *"Do they have any permissions policies attached yet? Or groups? I'm not sure a bare account is going to be much good if they can't see anything..."*
    - The player must check to see if there are any associated IAM groups or policies for the existing user(s).
1. *"Ok, so we have some empty users, do you see any groups?"*
    - The player must find and inspect several IAM groups.
1. *"Ah there we go, what policies are attached to those groups?"*
    - The player must find the policies attached to the existing IAM groups.
    - This will be used to introduce viewing relationships between resources.
1. *"Great, we can make this work. Can you set up these permissions?"*
    - The player will add users to groups to enable permissions.
1. *"Before you send the login credentials to the admins, you should check to make sure the permissions are scoped properly."*
