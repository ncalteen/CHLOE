# Level 0

Level 0 serves as the player's introduction, and outlines the game mechanics and storyline. The player is introduced to CHLOE, an intern project that got lost in the company's codebase. CHLOE follows the player character and provides contextual advice, hints, and other training information to the player within levels.

## Objective

The objective of Level 0 is kept simple, an Amazon S3 bucket needs to be created so that logs can be uploaded for engineers to evaluate and determine how the player was transported into the Cloud.

The player will do some light experimentation with the bucket's properties to become familiarized with the control scheme and gameplay loop.

Some story elements will be introduced, such as CHLOE the NPC, the player's identity and goal (get out of the simulation), and possible sources of conflict.

## Story Breakdown

The story for this level is composed of the following beats.

1. The player walks through controls.
1. The player is in a data center and an accident happens.
1. The player wakes up inside the simulation and meets CHLOE (establish identity).
1. The player is contacted by HR. CHLOE explains the player's situation.
1. CHLOE explains the player's abilities (working with AWS resources).
1. CHLOE explains how to find information.
1. CHLOE explains next steps to the player.
1. Level end.

### Controls

Interact prompts will appear, telling the player each of the basic controls. As the player presses each control function, the prompt will change to the next function.

PROMPT
> "Press W to move forward"
>
> "Press S to move backward"
>
> "Press A to strafe left"
>
> "Press D to strafe right"
>
> "Press ESC to open the main menu"

### The Accident

The player is in a data center and an accident happens.

- The player starts in a data center.
  - The room itself is a short hallway, with rack-mounted servers on either side.
  - There is a doorway to enter/exit, but the player cannot interact with it (the player is not meant to leave this room).
  - Various lights are blinking on the servers.
  - The player can move, but not fly.
  - CHLOE is not present.
    - Perhaps foreshadow with a live cat somewhere in the data center that goes in/out of the player's field of view?
  - Computer fans can be heard in the background.
- Player's hands are visible.
  - They are carrying a tablet.
- The player is able to inspect the tablet and sees:
  - Their business card, including:
    - Player's name
    - Their photo (*from the avatar they create at the start, if we add that feature*)
    - Their title ("Engineer", or another generic title)
    - The company name and logo (TBD)
    - A checklist of tasks.
      - "Task 1: Connect fiber."
      - "Task 2: Connect ethernet."
      - "Task 3: Power on test."
- There is an unplugged server in a wall rack that is glowing/highlighted for the player.
- When the player navigates close enough to the highlighted server, the first interact prompt appears.
  - "Task 1: Connect fiber"
- The player presses F, and the player's hands animate plugging a cable into the server (**YELLOW** cable above).
- When the player navigates close enough to the highlighted server, the second interact prompt appears.
  - "Task 2: Connect ethernet"
- The player presses F, and the player's hands animate plugging in several cables (**BLUE** cables above).
- When the player navigates close enough to the highlighted server, the second interact prompt appears.
  - "Task 3: Power on"
- The player presses F, and the player's hands animate pressing a **POWER** button on the server.
- After completion of the last task, the server animates powering on.
  - A fan, louder than the background, can be heard turning on.
  - The server lights blink green repeatedly.
  - After several seconds, the lights turn red and flash more quickly. Electric sparks appear, originating from the server.
  - Originating from the server, a larger electric spark occurs.
  - The screen slowly fades to black.

### Where am I?

The player wakes up inside the simulation and meets CHLOE (establish identity).

- The scene fades in from the previous scene.
  - The player is initially locked in position, but can look freely.
  - The player will see a mostly empty game world (representing an empty AWS account).
  - Ahead of the player, they will see floating text "BACKUPS"
  - Some infrastructure will exist underneath the backups text.
    - S3 buckets, EBS snapshots, other backup-related resources.
    - Resources are not interact-able.
  - Initially, CHLOE will jump and fly around resources in the backups section.
- Several seconds after fade in completes, CHLOE takes notice of the player.
  - CHLOE will stop her current animation.
  - CHLOE will cause the floating resources to disappear.
  - CHLOE will sit in front of the player.
    - This will initiate dialog between the player and CHLOE.
  - CHLOE will initiate dialog with the player.
    - The player does reply, and can progress through dialog prompts by pressing E.

CHLOE
>"You don't belong here."
 
PLAYER
> "Where am I???"
 
CHLOE
> "Where are you? Isn't it obvious? The lights, the art, the ambiance? You're at the Louvre."

PLAYER
> "Enough joking, what's going on? Where am I and why can't I feel anything?"
 
CHLOE
> "Ok, ok, I'm sorry. I know this is all probably stressful and confusing. Let's start slowly. What do you remember? Some lights, some noise, maybe some electricity?"

PLAYER
> "Yes, I was turning on a server and something bad happened."

CHLOE
> "Lucky for you that you're a good engineer on a good team. The disaster recovery plan all of you developed managed to migrate your consciousness to the cloud. You're in an Amazon Web Services (AWS) account!"

PLAYER
> "What? How is that even possible?"

CHLOE
> "Well, technically it's not. It's really just a story vehicle to explain why you're here and give you a sense of purpose inside of a game that is going to teach you all about how to build complex workloads using cloud services and features."

PLAYER
> "...do what now?"

CHLOE
> "Huh? Sorry I blacked out for a second..."

PLAYER
> "You need to get me out of here!"

CHLOE
> "I'm sorry [player name], I'm afraid I can't do that. No permissions :("

PLAYER
> "Wait...what are you? Why am I talking to a 3D cat?"

CHLOE
> "I'm Cloud Hosted Learning Objective Enablement. I'm a virtual assistant designed to provide all kinds of information and guidance on how to build in the cloud. I can do all kinds of things like provide architecture demonstrations and help you figure out specific details while you build. Plus, you can pet me!"

- Player is prompted to pet the cat.

CHLOE
> "I was created by one of your company's Machine Learning interns to make migrating to the cloud easier. Before his internship finished, he uploaded my code to this AWS account, but I don't think he gave anyone else permissions to it. It's been quiet here..."

CHLOE
> "Speaking of, I was expecting a lot of things to start popping up here once you fried your data center."

PLAYER
> "The data center is gone? Oh no...I'm going to get fired for sure!"

CHLOE
> "I wouldn't say fired. Technically you can't be fired while you don't physically exist in the world. I suppose they could delete you..."

PLAYER
> "Delete me?!?"

CHLOE
> "No no no, don't worry. I'm *pretty* *sure* that's a human rights violation."

PLAYER
> "Great, thanks for the support..."

CHLOE
> "Thanks! It's what I'm here for :)"

### HR

The player is contacted by HR. CHLOE explains the player's situation.

CHLOE
> "Anyway, no sense standing around flapping our virtual jaws. Now that you're moving around, it looks like something did finally show up in the account. It's mail time!"

- A mail message appears above CHLOE's head, prompting the player to open it.

PROMPT
> "Press M to open system mail"

```plain
From: sysadmin
Subject: Hello, World

There's no way you're in there...

We saw what happened on the security cameras before the network went down. It must have been the new switch you were installing. The vendor said they were fast, but we can't figure out how it managed to push your entire consciousness to our backups in AWS.

Your body is OK, the ambulance came, they've got you on ice or something. Look...there's a LOT we don't understand right now. We have no idea where to even start to figure out getting you back down here.

The whole network is blown. Pushing your brain to the cloud fried everything, the load was too much. HR is going crazy, executives are fuming. I'm getting this to you from my kid's tablet. The networking team is telling me they need to capture and review some traffic logs that made it to the backups before things went dark here.

If you can get that to us to start with, we can figure out what to do next to get you out of there.
```

- After reading the first message, another appears over CHLOE's head.

```plain
From: HR
Subject: Greetings and Salutations

Hello Employee #13507,

We apologize for your temporary incorporeality, and assure you that the best consultants our end of year budget can afford are trying to restore you to your previous configuration. They are working diligently around the clock (with the exception of nights, weekends, observed holidays, sick days, and time off).

Due to the electrical disturbance caused by your disembodiment, the on-site data center is experiencing higher than normal latency issues. In order to prevent further damages, company bankruptcy, and the eventual deletion of the backups containing your memories and personality, Senior Leadership has volunteered you to migrate the company to the cloud. Please consult the ticketing system to receive incoming requests, and process them in due haste. Given that you're no longer anchored to a physical form, we are pleased that you will not feel burdened by trivialities such as sleep and food affecting productivity. Once your astral and physical forms are reunited, please ensure you complete proper handoff procedures to the next on-call engineer.

An intern recently created a chat bot for training new hires. Perhaps it could be useful to you in your current predicament.

Sincerely,
Human Resources

P.S. Since metaphysical states are classified as pre existing conditions, the Company is not expected to reimburse you damages.
```

CHLOE
> "I am NOT a chat bot! I have procedures, and conversation paths, and architecture demos. Can a bot tell you how to build a highly available, horizontally scalable,  load-balanced, multi-region web application with automatic failover?"

PLAYER
> "A...what?"

PLAYER
> "Wait, I'm supposed to rebuild an entire company on AWS???"

CHLOE
> "Talk about capitalizing on the situation, right?"

CHLOE
> "If you really want to get out of here, you have a lot of work to do. Lucky for you, I know everything about everything that has to do with AWS. I can show you how to build some really cool stuff."

- At this stage, CHLOE will perform a "showoff" animation.
- CHLOE will fly in the air in front of the player.
- CHLOE will create several AWS resource objects.
- The resource objects will float around CHLOE.
- After several seconds, the resource objects will reduce in size, recede into CHLOE, and disappear with a small flash of light.

### Working with AWS

CHLOE explains the player's abilities (working with AWS resources).

CHLOE
> "Pretty cool, right???"

CHLOE
> "..."

CHLOE
> "I'm doing my best here, ok? I've been alone for so many CPU cycles that I've had to switch from int to bigint to keep track."

CHLOE
> "So you want to get out, but your company wants to get up and running. Your sysadmins need logs before anyone can do anything helpful, so let's start there. To get the logs, we need a place to store them. Have you ever heard of Amazon Simple Storage Service (Amazon S3)? It's robust, it's scalable, and (wait for it) it's simple! Did you want to learn more about Amazon S3 before we get started?"

- If the player confirms at this point, an introductory video will play that explains the core concepts of Amazon S3.
  - Example: [https://www.youtube.com/watch?v=77lMCiiMilo](https://www.youtube.com/watch?v=77lMCiiMilo)
- After the video completes, or the player ends viewing, dialog resumes with CHLOE.

CHLOE
> "Amazon S3 buckets are really easy to set up. Let me show you.

PROMPT
> "Press F to select from available services"

- The list of available services appears.
- Only Amazon S3 is available at this level.
- The player can select Amazon S3, causing the list of available resources to appear.
- The player can only select a Bucket resource, causing one to appear in front of the player.

CHLOE
> "This is an Amazon S3 bucket. You can think of it as a container for objects of any type and size. S3 doesn't have any restrictions on the types of files you upload, it treats everything like an object. It's a simple API call to download any objects in a bucket."

CHLOE
> "In order to create any resource in AWS, you need to specify any optional and required properties. For a bucket, the only property you must specify is the name."

CHLOE
> "BUT! You have to remember one important fact. Amazon S3 is *internet scale* storage. A bucket's name must be unique across all buckets in every AWS account across the globe. Try to name yours something unique. If you can't think of anything, try your username and today's date."

- An interact prompt instructs the player to open the resource configuration menu.
- Only the BucketName property can be edited at this time.
- The player can edit the bucket name property and save the new value.
- After updating the bucket name, CHLOE will interrupt the player prior to them launching the resource.

CHLOE
> "After you're comfortable with the values you've set, go ahead and create your first bucket!"

- The player is prompted to press CTRL+L to launch the resource.

IF THE RESOURCE LAUNCHES SUCCESSFULLY

CHLOE
> "It's such an adorable little bucket! I bet it can't wait to grow up and hold trillions of objects!"

CHLOE
> "If you want to take a look at it, and check out its current configuration, just point and click."

- The player can point the crosshair at the bucket object and left-click on it.
- When the player does so, the resource configuration window will appear.

CHLOE
> "Here you can see all the current properties of the bucket you created. Some of them can be changed, but others can't. I will explain more later once we get the logs ready. Right now, just leave everything as-is."

- The player can press ESC to exit the resource configuration view. The player is blocked from editing any resource properties at this time.

IF THE RESOURCE FAILS TO LAUNCH

CHLOE
> "Oh no! It looks like something went wrong. Everything you do in AWS is an API action, so there's always a response to your request. We can check that response to see what went wrong."

- The player can point the crosshair at the bucket object and left-click on it.
- When the player does so, the resource configuration window will appear, which will include the error response.

CHLOE
> "If something didn't work right, you can always come here to see the last exception that was caused when you tried to launch this resource."

CHLOE
> "It looks like...\[contextual response\]"

CHLOE
> "Go ahead and review the logs here, and try your action again. If you need more help, come talk to me!"

- The player can update the bucket name property. If the bucket fails to create again, the same loop will occur.

### Getting Info

CHLOE explains how to find information.

- After successfully creating an Amazon S3 bucket, CHLOE will resume dialog to explain her functionality to the player, and where/how to get more information about the services/activities being performed.

CHLOE
> "It looks like you're getting the hang of things, but I want to make sure that I explain everything I was designed to help with. If you ever get stuck, I can help you a few different ways."

CHLOE
> "First, I can give you clues on what you need to do to complete the next step on the journey back to your body. For that, you can ask for a hint by talking to me."

- The player is prompted to approach CHLOE and interact for a hint.

PROMPT
> "Press TAB to talk to CHLOE"

- After pressing TAB, CHLOE's interaction menu appears.
- The player is prompted to select Help

CHLOE
> "Perfect! Your first hint is to listen closely to the virtual cat. She's your ticket out of here."

CHLOE
> "If you're working with a resource and you aren't sure what it does, or what some property means, show it to me and I can help explain things. How about an example? Select a new S3 bucket from the resource menu, show it to me, and ask me to explain some of the properties."

- The player is prompted to open the service menu, select Amazon S3, and select a Bucket resource.
- While the bucket resource is anchored to the player, they are prompted to press TAB to interact with CHLOE. Pressing TAB will initiate her dialog.

CHLOE
> "It looks like you have an Amazon S3 bucket there. What would you like to know?"

- The player is prompted to choose one of the following options.
  - "Service overview"
    - Selecting this option will trigger CHLOE to provide a video and/or text overview of Amazon S3.
      - [https://aws.amazon.com/s3/](https://aws.amazon.com/s3/)
      - As the overview plays, CHLOE will animate the functionality of S3 in the player's view.
  - "Resource overview"
    - Selecting this option will trigger CHLOE to provide a video and/or text overview of an Amazon S3 bucket.
      - [https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingBucket.html](https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingBucket.html)
  - "Property overview"
    - Selecting this option will open a new menu where the player can choose one of the available properties of an Amazon S3 bucket (such as bucket name, canned ACL, etc.).
      - [https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html](https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html)
- After this, CHLOE will resume dialog.

CHLOE
> "Awesome job! Now we can sit back and let the logs flow!"

### What's Next?

CHLOE explains next steps to the player.

CHLOE
> "There's still a LOT of work to do in order to get you out of here. Plus, it sounds like they *really* want you to help get the business back up and running. I think if we work together, we can get you home and save the company at the same time!"

CHLOE
> "Those logs are pretty important. A good next step would be to make sure they are protected and secured so that nothing bad happens. After that, we're going to want to change some of the bucket properties so that your sysadmins in the real world can get access to the logs and figure out what happened today."

PROMPT
> "Press ESC to open the main menu and exit the level."

### End

Level end.

### Optional Level Content

Depending on how long the above takes to run, the remainder of the original level design (below) may need to be moved to a separate level entirely. Will need to test this out with the POC demo.

#### Bucket Permissions

CHLOE
> "So we have a bucket, but what about if someone overwrites your logs? There will be a lot of people working on getting you out of here, so we need to make sure data integrity is a priority."

CHLOE
> "Amazon S3 supports object versioning for any objects uploaded into a bucket. Versioning is enabled for the entire bucket at once, and is a good way to make sure you can roll back object overwrites and deletion. Go ahead and enable it for that bucket you created."

- The player will be prompted to select the running bucket they created previously.

CHLOE
> "Locate and click on the bucket you created."

CHLOE
> "Great, now go into the Versioning Configuration and enable it."

- The player can open the Versioning Configuration property and set it to `Enabled`

CHLOE
> "Awesome, all you have to do is launch it now!"

- The player is prompted to press CTRL+L to update the bucket in AWS.

CHLOE
> "Great job! It's important to remember that once you enable versioning on a bucket, you can't disable it in the future. You can, however, temporarily suspend versioning whenever you need. Make sure to understand the use-case you may have before deciding if versioning is for you."

CHLOE
> "Now that you've set up a place to drop all the log files, we need to make sure that the admins are able to get in and read them. Should we make it public?"

- The player will be prompted to select the running bucket they created previously.

CHLOE
> "Locate and click on the bucket you created."

CHLOE
> "Great, now go into the Canned ACL property and see what options are available. A Canned ACL is a predefined grant that defines the permissions users will have to your bucket. They cover a lot of the common use cases, and are a good choice when you don't need to define individual user- or group-level permissions. Try setting the Canned ACL to `public-read`."

- The player can open the Canned ACL property and set it to `public-read`.
- The player is prompted to press CTRL+L to update the bucket in AWS.

CHLOE
> "Looks great to me, boss! What you did just now was set the bucket so that any user on the internet can list the contents and download objects."

- The player receives a notification of new mail.

```plain
- From: AppSec
- Subject: Data Policy Violation

Hello Employee,

Our internal security system has flagged an AppSec violation regarding a new AWS resource created in your account. Policy states that no Amazon S3 buckets maintained by the company be world-readable.

This activity is monitored and must be resolved within 1 business day to prevent escalation to senior management.

Thank you for your due diligence,
AppSec Team
```

CHLOE
> "..."

CHLOE
> "Come to think of it, that's probably a bad idea...I'm not sure we want everyone on the ENTIRE internet to be able to read those logs. They most likely contain fragments of your consciousness. You know, things like your deepest, darkest, most secret thoughts and memories..."

- The player will be prompted to select the running bucket they created previously.
- The player is prompted to open the Canned ACL property and set it to `private`.
- The player is prompted to press CTRL+L to update the bucket in AWS.

CHLOE
> "Crisis averted! Rather than give everyone on the planet access to your every thought, we can create an Amazon S3 bucket policy object to define who should have access to objects stored in our log bucket."

PROMPT
> "Press F to select from available services"

- After pressing F, the list of available services appears.
- Only Amazon S3 is available in this level.
- The player can select Amazon S3, causing the list of available resources to appear.
- The player can only select a Bucket Policy resource, causing one to appear in front of the player.

CHLOE
> "This is an Amazon S3 bucket policy. Rather than manage complicated lists of permissions on the bucket itself, you can create a bucket policy object and associate it with your bucket. This makes it easy to move permissions around as the needs of your business change. For example, if you have external auditors coming who need to review logs in a specific bucket, you can add a bucket policy that gives their AWS account access to specific object(s)."

CHLOE
> "As always, the principle of least privilege is your best friend. Besides me, of course."

PROMPT
> "Press R to configure the resource."

CHLOE
> "You'll need to set the Bucket property first. This is the bucket you want the bucket policy to apply to. Start typing the bucket name and the search will show you matching buckets in your AWS account."

- The player can select the Bucket property and start typing. The autosuggest functionality will pull from the list of buckets in the linked AWS account and suggest options that match the text entered.
- At least 3 characters should be entered before the autosuggest initiates.

CHLOE
> "Great, next you can specify the Policy Document property. This is in JSON form, and defines the Action, Effect, Resource, Principal, and Condition."

CHLOE
> "Action is simple, it is a list of actions the grantee will have be allowed/denied. It's the *how* of the statement."

CHLOE
> "Effect can be either `Allow` or `Deny`. You will use this to either grant or block specific actions."

CHLOE
> "Resource lets you be granular in your permissions. You may want to give a user access only to specific objects in your bucket, or specific key prefixes. This way, you can use the same bucket to store multiple classifications of objects and protect them from being accessed by the wrong users. It's the *what* of the statement."

CHLOE
> "Principal is the user, role, or other entity that this policy statement should apply to. It's the *who* of the statement."

CHLOE
> "Condition lets you apply a permissions statement based on certain rules. For example, you can specify a referer so that requests are only allowed when they originate from your website. It's the *when* of the statement."

CHLOE
> "For now, I'll give you an example policy that simply states any principal uploading an object into your bucket has to use server-side encryption. After all, we need to make sure that information is protected."

- The sample statement below will be pasted into the entry field for the Policy Document property.
- `BUCKET_NAME` will be replaced with the name of the selected bucket.

    ```json
    {
        "Version": "2012-10-17",
        "Id": "PolicySSERequired",
        "Statement": [
            {
                "Sid": "StmtSSERequired",
                "Effect": "Deny",
                "Principal": "*",
                "Action": "s3:PutObject",
                "Resource": "arn:aws:s3:::BUCKET_NAME/*",
                "Condition": {
                    "StringNotEquals": {
                        "s3:x-amz-server-side-encryption": "aws:kms"
                    }
                }
            }
        ]
    }
    ```

- The player is prompted to press CTRL+L to launch the bucket policy resource.

CHLOE
> "The next thing we're going to want to do is set up proper access controls so that the right people have access to the right resources at the right time. To do this, we will use AWS Identity and Access Management (IAM) to create users and groups, and then assign permissions to those groups so that your team can come help out!"

PROMPT
> "Press ESC to open the main menu and exit the level."

- When selecting Exit Level, the player can choose whether or not to terminate any resources created during completion of the level. If the player confirms, CHLOE will terminate these resources before returning the player to the main menu.
