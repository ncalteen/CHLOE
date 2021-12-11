# EC2

Introduces players to on-demand compute using Amazon Elastic Compute Cloud (Amazon EC2). The context of this activity is focused on giving administrators a location to run log analysis tools that they will use to determine the origin of the player's predicament.

## Objective

Players will launch instances, monitor their startup progression, modify security group(s), resize instances, and terminate instances.

```plain
"I'm seeing a...lot of data. I don't think humans can go through all these logs on their own. Maybe we can do them a favor and set up some tools to automate things a bit? Since you're stuck here, we can take advantage of the massive computing power available."
```

## Level Tasks/Goals

1. *Go ahead and try launching an Amazon EC2 instance. Once everything looks good we can install tools after. Make sure to set up termination protection. The log analysis results won't be any good to you if someone terminates the instance tomorrow morning.*
    - The player must launch an Amazon EC2 instance.
1. *It looks like it's launching. Can you verify the System/Instance reachability checks look OK? The system log should tell us if everything is going well.*
    - The player must inspect the Amazon EC2 instance.
1. *You'll need to make sure that the instance is reachable. Amazon EC2 security groups control what inbound/outbound access an instance can have.*
    - The player must add a rule to the associated Amazon EC2 security group.
1. *Everything looks good, but there's a massive amount of data to go through. I don't think this instance is big enough to handle the work. We need more power!*
    - The player must resize the instance type and Amazon EBS volume.
1. *Just as a sanity check, can you make sure termination protection works?*
    - The player must test terminating the instance (it should fail).
