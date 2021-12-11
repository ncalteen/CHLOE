# Game Overview

Cloud Hosted Learning Objective Enablement (CHLOE), a game-based training simulation for visual learners. CHLOE's single-player, story-driven game teaches learners core AWS services, concepts, and best practices, and how to use the [AWS Well-Architected Framework](https://aws.amazon.com/architecture/well-architected/) to optimize their cloud workloads. In simulation mode, players can use CHLOE to render AWS accounts as 3D environments, where they are able to view, launch, update, and terminate resources in real-time. CHLOE provides contextual training to solve real-world use cases through audiovisual explanations and tutorials, as well as animated architecture demonstrations.

The story of CHLOE's game mode starts with a data center incident causing the player to be stuck inside their company's AWS account. To return to the real world, the player must rebuild their company's broken applications on AWS using the Well-Architected Framework. As the player completes levels, they are trained on various products and services, and given additional learning resources for later consumption. Players will ultimately beat the game by collecting the [AWS Well-Architected Pillars](https://docs.aws.amazon.com/wellarchitected/latest/framework/the-pillars-of-the-framework.html) and defeating the antagonist, [Chaos Monkey](https://netflix.github.io/chaosmonkey/) (a virtual representation of [Chaos Engineering](https://principlesofchaos.org/)).

In game mode, players earn badges by completing tasks, which can be used to showcase their knowledge to the AWS community. In simulation mode, players can create 3D architecture environments, or synchronize with their AWS accounts in real-time. View filters for the Well-Architected Pillars provide feedback on areas of strength or improvement. Players can use the in-game assistant, CHLOE, for just-in-time (JIT) training, providing contextual information while building.

In simulation mode, players can connect to one or more AWS accounts using federation or AWS Identity and Access Management (IAM) credentials. Once connected, players can design solutions in real time and get contextual answers to complex scenarios. CHLOE can be linked to existing AWS accounts to build dynamic, 3D architecture diagrams and live workloads in real-time. Players can enable multiple camera overlays to visualize performance, cost, reliability, security, and other status information based on the Well-Architected Framework. Players can troubleshoot resource configuration problems, investigate cost reduction opportunities, and learn how to optimize infrastructure in a visual, intuitive manner. If players do not wish to connect CHLOE to their account, simulation mode can be used to create 3D architecture diagrams for reference and decision-making.

CHLOE provides just-in-time (JIT) training, giving access to the right information exactly when a player needs it while configuring their workloads. Using an in-game assistant named CHLOE, players can get contextual advice and information related to specific tasks they are performing. Players can request information in the form of audio/text explanations, streaming video, or in-game architecture demonstrations.

## Premise

CHLOE is a cloud training game that makes deeply technical concepts easy to visualize and understand in a way that entices users to dive deeper and learn more. CHLOE incorporates characteristics from three categories of [Game Thinking](https://www.gamified.uk/gamification-framework/differences-between-gamification-and-games/):
gamification, simulation, and serious games.

- **Gamification:** Specifically, CHLOE focuses on **Content Gamification**, where game elements, mechanics, and thinking are applied to alter content and make it more game-like. This is not to be confused with **Structural Gamification**, which applies game elements without alterations to the content itself.
- **Simulation:** A virtual representation of something from the real world. In the case of CHLOE, it is instead a virtual representation of something from the virtual world which has, as of yet, not been represented outside of text.
- **Serious Game:** Games created for reasons other than pure entertainment. Unlike a simulation, serious games incorporate gameplay elements to solve challenges and gain deeper understanding as the game progresses. Serious games can potentially play well as a game in their own right, if done properly.

CHLOE provides a way for users to explore various scenarios; including solving issues, creating new items, and having free play to explore AWS. After using CHLOE, technical users have a visual point of reference to use when designing complex AWS infrastructure. Non-technical users have an entertaining and engaging way to discuss AWS with their audience that will drive further exploration and adoption. CHLOE can abstract away the initial learning curve that comes with adoption of new tooling and infrastructure, giving users access to the details they need to complete a task, while increasing complexity at a reasonable pace.

CHLOE creates short and long term learning opportunities through the use of "world event"-style missions, levels, and story acts. Each activity is rewarded using a mix of virtual badges, achievements, and points/in-game currency (which can be used to spend on customizations for CHLOE).

### Gameplay Hook

- Give visual/spatial learners a point of reference for development.
- Abstract away the initial learning curve of AWS.
- Visualize cloud infrastructure in a way that's never been done before.
- Give players an opportunity to solve technically challenging scenarios and develop their skills.

## Theme

CHLOE will borrow visual and audio characteristics from [Synthwave](https://en.wikipedia.org/wiki/Synthwave) and [Vaporwave](https://en.wikipedia.org/wiki/Vaporwave) in both color and sound. As described in their corresponding links, characteristics from each genre that will be prevalent in CHLOE include the following.

### Personality

A common trend in our industry is a constant sense of [impostor syndrome](https://en.wikipedia.org/wiki/Impostor_syndrome). The last thing I want is for CHLOE to make a player feel stupid. CHLOE demonstrates confidence without being patronizing or smug. As a learning/simulation tool, CHLOE adheres to the philosophy that learners want to be enabled without being made to feel like they are not learning fast enough, or are not capable of performing the task at hand. This is not to say CHLOE will lack challenge, the concepts being taught range from introductory to deeply technical, and will increase in complexity and depth as the user gains more cloud experience.

- The in-game assistant, CHLOE, is a companion character that will dialog with the user in different contexts to provide meaningful information/resources in a lighthearted manner.
- CHLOE will inject humor/quirk where appropriate to provide an entertaining setting for the gameplay experience. The overall style is snarky and self-deprecating, with the goal of entertaining the player without affecting personal development/empowerment.
- In Simulation Mode, described later, such humor/quirk characteristics are reduced/removed. The goal of Simulation Mode is to provide an infrastructure management and visualization tool, not so much a gameplay experience.

### Visual Characteristics

- [Glitch Art](https://en.wikipedia.org/wiki/Glitch_art)
  - Things break in AWS...constantly. Glitch Art is a visually interesting approach to call these things out.
- [Synthwave Art](https://www.pinterest.com/search/pins/?rs=ac&len=2&q=synthwave%20art&eq=synthwave&etslf=3827&term_meta%5B%5D=synthwave%7Cautocomplete%7C0&term_meta%5B%5D=art%7Cautocomplete%7C0)
- Neon
- Gridlines
- Environment
  - The world is open and flat, to allow for freedom of movement and positioning of resources.
  - This also emphasizes the expansive nature and potential of AWS.
  - In video game design, completely open worlds are potentially overwhelming for the player. The purpose of doing so in CHLOE is to represent AWS as an empty canvas on which the player can build their own world.

### Audio Characteristics

The audio style of CHLOE will be slower-paced and low volume. The purpose of the music within the simulation is to serve more as background than to contribute significantly to the mood or story. High-repetition, instrumental music will help to focus the user on the task at hand without distraction.

For the same purpose, as well as avoiding localization issues, recorded vocals will not be included. The only speaking character, CHLOE, will be implemented using subtitles, with localization done with [Amazon Translate](https://aws.amazon.com/translate/) (stretch goal after initial release).

The main character will not be voiced. This is a common design strategy in games where the goal is for the player to feel more like the main character. A character's personality predicates their voice, which has the potential to alienate players who do not align with that personality. Subtitles are used instead of voice for "spoken" sections of the game.

### References

- "...electronic drums, gated reverb, and analog synthesizer bass lines and leads..." - [Wikipedia](https://en.wikipedia.org/wiki/Synthwave)
- [Vaporwave Aesthetic](https://www.youtube.com/watch?v=DVbF878LdKA)
- [Timecop1983](https://www.youtube.com/watch?v=_Ci0Kgdpgsw)

#### Cultural References

- [TRON: Legacy](https://www.imdb.com/title/tt1104001/)
- [KidMoGraph](https://www.kidmograph.com/)
- [Neon Drive](https://store.steampowered.com/app/433910/Neon_Drive/)

## Inclusion and Diversity

A stretch goal of this project will be to include support for alternative input types for players with disabilities. In the long term, I would love to use CHLOE to help train up new technical users through programs like the [Able Gamers Charity](https://ablegamers.org/).

## The Player

The user can navigate through the menu/world using standard first-person controls. The player does not have the ability to jump. Instead they can "fly" by controlling their vertical elevation.

VR support will be developed in a separate version of the client. Research has shown that there are concerns around requiring VR hardware, as this introduces additional cost and complexity. Because of this, players have stated that this requirement would prohibit their ability to use CHLOE. VR will be supported for marketing efforts such as conferences and player-scheduled VR training events, as well as for players with VR-ready hardware.

## Multiplayer

Initially I was not sure how much interest there was for real-time multiplayer functionality such as player presence, chat, etc. For multiple players connecting CHLOE to the same AWS account(s), they are able to utilize the same resource state data collection infrastructure. Each connected player will have the same resource data at the same time, effectively allowing multiplayer interaction.

After initial release, the project team will more deeply investigate multiplayer benefits and opportunities as a later release.

## Marketing

CHLOE will be marketed as a training tool and visual simulation platform. Primary avenues of marketing will be conferences/trade shows (demo booths, workshop sessions, etc.), player meetings, and streaming media (Twitch/YouTube).

For marketing via specific events, unique avatar customization rewards can be provided. For example, redeemable codes for unique meshes for CHLOE that would transform her into new forms/animals.

## Story Outline

The player is introduced to the game as an IT technician working in their company's data center. The game opens into a cutscene where the player is performing some maintenance activities in a small data center. An accident occurs in the data center which results in the player blacking out and waking up inside an AWS account.

When the player wakes up, they are introduced to CHLOE who explains the player's situation and familiarizes them with the core controls. The player is introduced to cloud computing by CHLOE, who explains that the player needs to use AWS to "build their way out" of the account and return to their body. Obviously this is a physical impossibility in the real world, so this also serves as a chance to break the fourth wall and set the tone of the game.

The player is introduced to core AWS services and concepts in order to establish communication with the outside world. Upon doing so, the player is introduced to the game's main antagonist, Chaos Monkey. After an initial "battle" to Chaos Monkey, CHLOE informs the player that they will need to obtain the AWS Well-Architected Pillars in order to have enough knowledge/strength to defeat the antagonist.

Each pillar covers different cloud concepts and AWS products, and is guarded by a mini-boss. Each mini-boss can be defeated by using concepts learned while the player works towards achieving each pillar. After achieving all the pillars, the player can return to fight Chaos Monkey.

Boss battles do not include actual "combat". The objective to defeat each boss is to architect solutions in such a way that the boss is rendered powerless against them (for example: using AWS Auto Scaling to prevent a mini boss from overloading your website with requests).

Once Chaos Monkey is defeated, players can open an AWS Direct Connect connection back to their company's HQ, which serves as a portal for the player to return home. Completion of the first act also opens a series of acts based on individual career paths, which players can complete as they desire.

## Features

### In-Game Assistant (CHLOE)

The in-game assistant, CHLOE, acts as a source of information, hints, instructional material, and resource generation. Within the simulation, CHLOE is rendered as a wireframe cat. As a post-release effort, CHLOE will support redeemable codes to unlock additional CHLOE wireframes (other animals, fantasy creatures, and so on). When the user interacts with CHLOE, several options are available.

Yes, the player can pet the cat.

One of the most popular examples of a similar character is [Cortana](https://en.wikipedia.org/wiki/Cortana_(Halo)) from the *Halo: Combat Evolved* series. A "ride-along" character can be critical in guiding and teaching players, as well as establishing a sense of identity through their relationship and dialogue.

Humans regularly anthropomorphize inanimate and non-human entities so that they can identify with and relate to them ([source](https://psychcentral.com/news/2018/03/01/why-do-we-anthropomorphize)). This occurs often in media and entertainment, but equally often in peoples' every-day lives. Examples include [house cleaning devices](https://www.wired.com/story/roomba-robot-consciousness-enlightenment/), [plants](https://www.wired.com/story/roomba-robot-consciousness-enlightenment/), [cars](https://www.wdsu.com/article/more-than-40-percent-of-people-name-their-vehicle-do-you/23567311), and more.

The full acronym, Cloud Hosted Learning Objective Enablement, emphasizes itself as a solution to the challenge players experience trying to achieve specific, targeted learning objectives that prevent them from moving forward with a specific problem. CHLOE enables players to achieve their learning objectives quickly so that they can grow and build in the cloud.

CHLOE acts as a guide. She is responsible for guiding and developing players through their experience, and provides additional context throughout the game story. Translated literally, the name refers to new spring growth. In this vein, CHLOE helps grow and develop players throughout their cloud journey.

When working in the game and interacting with CHLOE, the player has the option of performing the following actions.

#### What is this for?

When holding a resource entity, the user can choose this option to see and/or hear an explanation of what the resource is, what purpose it serves, and how players are using it on AWS. This can be presented in a number of ways, including streaming video, text, or audio. The initial effort will focus on streaming a related video from AWS' YouTube channel. Should this introduce problems, learning content can be packaged as part of the application installation.

#### How do I?

When selecting this option, the player can choose from a list of available scenarios (such as *How do I...create a static website with CloudFront integration?*). These tasks are simple in nature (examples below). The purpose of this feature is to quickly explain to a user how to create some resource type with a predefined configuration.

- *How do I... → Create a static website bucket with redirects and CORS?*
- *How do I... → Add an Availability Zone to a load balancer?*

When a *How do I* task is chosen, an on-screen animation will begin. The animation will show CHLOE launching the needed resources and configuration to create the proposed architecture. The resources will not be instantiated in any linked account(s).

After the demonstration completes, the player has the option to modify the configuration of each involved resource and launch them. From the game engine perspective, the AWS resources are created with some default configuration as specified by the workload, but they are not launched yet. The player must choose to launch them after viewing the configuration.

#### Resource Launch, Update, and Terminate Actions

After the user launches, updates, or terminates an AWS resource, CHLOE acts as the driver for the action by performing an animation relevant to the action and resource type.

### Visual Parameters

A common feedback item from players learning AWS has been that the myriad configuration options and data available to them in the AWS Management Console has been overwhelming at best. Specifically, the UI of CHLOE must be simple, but convey important data in a clear and meaningful way.

One way to accomplish this is to reduce text usage wherever possible, opting instead for visual representation of different configurations and states. Using position, scale, color, animation, sound, and other characteristics (with accessibility still in mind), information currently conveyed as text can be represented in other ways that can be more intuitively viewed and modified by the player.

As an example, [VRHuman.com](http://vrhuman.com/) (owner: Vladimir Ilic), demonstrates a collection of VR assets such as buttons, sliders, and knobs for use in VR applications. This can be viewed [here](http://www.vrhuman.com/portfolio/vr-asset-essentials-switches-levers-buttons/).

Working with AWS resources, the following use cases explain some of the potential for creating "visual parameters".

#### Amazon S3 bucket properties

- AccelerateConfiguration is represented as a switch (on or off).
- AccessControl is represented as a dial with the supported options.
- ObjectLockEnabled is represented as a lock object that can be closed (true) or opened (false).
- PublicAccessBlockConfiguration is represented as several buttons that can be pressed to enable different access settings.

### Simulation Mode

The heart of the visualization component of CHLOE is Simulation Mode. The user is free to create and configure live AWS resources in real-time. In a sense, Simulation Mode turns AWS infrastructure engineering into a first-person/VR experience. Ultimately, CHLOE would allow builders to do their day to day job within a 3D world.

Simulation mode can be used both for building live AWS resources as well as visualization and construction of 3D architecture diagrams. Players will have the option to disable linking to AWS accounts, which disables the corresponding AWS API actions.

### Resource State Data Collection

When a user first starts CHLOE, they will be prompted to connect to one or more AWS accounts. If not done so already, the player must deploy an instance of the backend data aggregation infrastructure. This infrastructure is responsible for collecting resource state information and aggregating it into a format that CHLOE can query regularly to perform in-game state updates (adding newly created resources, updating resource info, deleting old resources, etc.).

AWS account linking will be supported for individual accounts or accounts that are part of an organization in AWS Organizations.

This has to be as close to free for the player as possible, while still being reasonably fast. Players will not want to wait 30 minutes for CHLOE to know what is in their account.

### Game Backend

The game backend saves and persists player progress, learning history, achievements, and other player metadata. This will be used both to persist "cloud saves" of player data and as the primary metrics gathering system to track adoption and usage.

### First-Person Camera/Controls

Users will navigate via first-person. Movement/navigation/flight will follow common conventions for first-person games.

### VR Camera/Controls

Users will navigate via a head-mounted display (HMD).

- Movement/navigation/flight will be supported using hand controls.
- Movement/navigation/flight will also support using full-body VR platforms (example: [Omni by Virtuix](https://www.virtuix.com/)).

### AWS Credentials Integration

When playing game levels, AWS integration is disabled. This is to remove the need for players to pay for running AWS resources while learning.

When playing in Simulation Mode, AWS credentials can be optionally included to sync the local environment with one or more AWS accounts.

Direct entry of access key ID/secret access key pairs will not be supported for security concerns.

### AWS Service Support

The initial supported AWS services are listed below.

- Amazon Simple Storage Service (Amazon S3)
- AWS Identity and Access Management (IAM)
- Amazon Virtual Private Cloud (Amazon VPC)
- Amazon Elastic Compute Cloud (Amazon EC2)
- AWS Auto Scaling
- AWS Lambda
- Amazon DynamoDB
- Amazon Relational Database Service (Amazon RDS)
- Amazon Simple Notification Service (Amazon SNS)
- Amazon Simple Queue Service (Amazon SQS)
- Amazon CloudWatch

The remaining AWS products and services will be posted in a public-facing roadmap where players can add support for specific services/resources.

### Ongoing/Patch Support

Due to the rapid pace of AWS service and feature releases, CHLOE will support end-user client patching. Due to the potential increased cost and complexity of building a standalone client, initial preference will be given to using existing clients like Steam.

### Resource Creation

Resources will be instantiated within CHLOE by the user through the user interface.

1. The user opens the resource selection menu.
1. The user navigates a list of supported AWS services and selects a
resource to create.
1. The resource entity is placed in the player's control and enabled
for interaction.
1. The user selects the resource configuration menu.
1. The user selects the desired configuration for the resource.
1. The user moves the resource to their preferred location.
1. The user confirms creation of the resource.
1. The resource creation request is sent to the configured AWS account.
1. CHLOE performs a creation animation.
1. Success/failure response is monitored by CHLOE.

### Resource Updates

Resources can be updated by the user. Live resources are updated in the linked AWS account.

1. The user selects an existing resource in the environment.
1. An information pane appears in the UI listing existing resource
configuration details.
1. The information pane fields are editable for service properties that
support in-place updates.
1. The user edits one or more fields.
1. The user selects the **Update** option.
1. CHLOE performs an update animation.
1. The resource update request is sent to the configured AWS account.

### Resource Deletion

Resources can be deleted by the user. This triggers deletion of the resource in the linked AWS account.

1. The user selects an existing resource.
1. An information pane appears in the UI listing existing resource configuration details.
1. The user selects the **Terminate** option.
1. The user reviews any warnings and confirms deletion.
1. CHLOE performs a termination animation.
1. The resource delete request is sent to the configured AWS account.
1. On resource deletion success, the entity is removed from the scene.
1. On resource deletion failure, the entity enters a corrupt state.
1. CHLOE notifies the user of the failed resource deletion.

### AWS Resource Errors

On create, update, delete requests, the corresponding AWS API action may succeed or fail. The user should be notified in an appropriate manner when action must be taken.

- On resource creation success, a success animation is invoked on the entity.
- On resource creation failure, a failure animation is invoked on the entity.
  - CHLOE notifies the user of resource creation failure.
  - On selecting the failed resource, the user is provided failure information from the AWS API response.
  - The player is given an option to update resource parameters and retry creation.
  - This follows the same workflow as **Resource Updates**.
- On resource update success, a success animation is invoked on the entity.
- On resource update failure, a failure animation is invoked on the entity.
  - CHLOE notifies the user of resource update failure.
  - If the resource is successfully rolled back by AWS to a known good state, a warning animation is invoked on the entity.
  - If the resource is not successfully rolled back by AWS to a known good state (or cannot be), a failure animation is invoked on the entity.
  - On selecting the failed resource, the user is provided failure information from the AWS API response.
  - The player is given an option to update resource parameters and retry the update.
  - This follows the same workflow as Resource Updates.
- On resource delete success, a delete animation is invoked on the entity and it is removed from the scene.
- On resource delete failure, a failure animation is invoked on the entity.
  - CHLOE notifies the user of resource delete failure.
  - On selecting the failed resource, the user is provided failure information from the AWS API response.
  - The user is given an option to retry the deletion.
  - If the resource has been deleted by another principal (such as another user in the console), deletion is treated as a success.

### Resource Links

Some AWS resources are inherently linked based on their properties (for example, an Amazon EC2 instance profile and an IAM role). In these cases, the resource link can be displayed for the user through the UI.

1. The user has two or more resources in their environment.
1. If two resources are dependent on one another, a **View Link** option is available in the UI. The visual representation is defined by the type of link.
1. Example: Amazon EC2 instance profile and IAM role are linked via line.
1. Example: Amazon VPC and subnet linked via nesting.

Users can also specify their own links for the purpose of logically organizing resources. User-created links are persistent until one or more linked resources are terminated.

### Resource Grouping and Movement

The player is able to select and move resources after they have been created either by the player or by the resource synchronization process. The positioning data is stored locally as part of the user's save information.

The player is able to group resources based on freeform data (example: grouping all the frontend web servers for a web application). This information is stored as [tags](https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html) on the corresponding AWS resource.

### Resource Synchronization

When playing CHLOE in simulation mode with synchronization enabled, CHLOE will regularly query the resource inventory backend for updated resource state information. This information is processed and used to perform the following tasks.

1. Creation of new game entities corresponding to resources in the information feed that did not exist in the last feed.
1. Deletion of game entities not in the information feed that did exist in the previous feed.
1. Update of game entities in the information feed that also existed in the previous feed.
1. Updating resource property values, grouping tags, etc.

The interval for performing synchronization requests can be configured by the user (in minutes and seconds).

### Resource Positioning

As resource synchronization takes place, CHLOE will automatically position and reposition resources in a logical manner. Some positioning criteria are as follows:

- Resources in the same region will be positioned more closely together.
  - A clear delineation will exist between AWS regions.
- Resources in the same AWS account will be positioned more closely together.
  - A clear delineation will exist between AWS accounts.
- Resources that are associated with a "container type" resource will be positioned within the container.
  - Example: Amazon EC2 instances are deployed into subnets. Thus, the EC2 instance resource must exist within a subnet container.
- Container type resources can be nested within one another, as well as cross boundaries into other containers.
  - Example: EC2 instances are deployed into subnets, which exist in Amazon VPCs. EC2 instances are associated with security groups. Security groups are specific to a VPC, but not to a subnet. Thus, the EC2 instance must exist in a subnet container, which exists in a VPC container. The security group container also must exist in the VPC container, but can encompass EC2 instances in multiple subnets.

Users will also have the ability to move resources within their environment to represent their desired architecture flow. **A resource cannot be manually moved outside of any container.** This may only occur when the resource properties have changed to reflect the new container hierarchy.

1. The user interacts with a resource within their environment.
1. The resource becomes movable, and is "placed" in the user's hand.
1. The user navigates to a new location and activates the resource.
1. The resource is placed in the specified location.
1. Metadata defining the resource layout is saved in the user's save data.

### Architecture Map

To support easier navigation of large-scale infrastructure, a level map will display the overall architecture from an overhead point of view. The map will be divided into the following sections.

- Region
- AWS Account

As the number of resources and their position change, the scale of the map will adjust accordingly.

### Heat Map Visualization

Heat map options will be available to display the following. This will be rendered in first-person mode by changing the presentation of the world through camera post-processing effects.

- Service-specific highlighting (Amazon EC2, Amazon S3, etc.)
- Cost
- [AWS Well-Architected](https://aws.amazon.com/architecture/well-architected/) rating (one for each pillar)
- AWS Config rule violations
- Amazon CloudWatch alarm status
  - The resources being monitored by the metric/alarm will be highlighted.

### Achievements

CHLOE will support an achievement system using a modular framework to define achievement progress and validation.
