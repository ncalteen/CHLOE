# Gameplay Considerations

## Core User Types

[Bartle's taxonomy of player types](https://en.wikipedia.org/wiki/Bartle_taxonomy_of_player_types) outlines a classification of video game players according to their preferred actions within a game. The following list includes references to how and where CHLOE can appeal to those types.

- **Achiever:** This player type likes to earn rewards or points that can be representative of their success in the game. CHLOE can appeal to this player by providing recognition and awards for completion of levels and missions. The inclusion of cosmetic rewards goes far to draw in this player type.
- **Explorer:** This player type likes to discover and immerse themselves in the game world. They like to work at their own pace. CHLOE can appeal to this player type by allowing freeform creation and expression in simulation mode. They are able to create as they please and (optionally) share creations with others.
- **Socializer:** Likes to build social connections with other players as well as computer-controlled characters with sufficient personality. CHLOE can appeal to this player type by creating social connections and systems where players can help one another (example: Discord). CHLOE herself provides an anthropomorphic character that can be interacted with.
- **Killers:** Thrives on competition with other players and disrupts the system. This player type is not a fully-intended audience of CHLOE, but may appeal to them by allowing freeform creation and expression in simulation mode. They are able to challenge the status-quo for existing infrastructure implementations.

## Game Design Elements

The following core game design elements drive successful games in the market ([source](https://trainingindustry.com/content/uploads/2017/07/enspire_cs_gamification_2016.pdf)).

### Achievement/Progression Elements

Game players get satisfaction from level accomplishment and skill development. Learners enjoy some types of recognition. The sense of progression motivates continued effort. Leaderboards provide a social status element, as to points and badges. In training, the course completion certificate signals achievement.

- **Badges:** Players will be able to earn badges for completion of each act, signifying they're developed expertise in each AWS Well-Architected Pillars.
- **Scoreboard:** CHLOE itself will not provide scoreboard or leaderboard functionality, as the focus of the experience is on building and collaboration. However, by integrating with AWS GameDay and/or AWS Jam events, CHLOE will be able to leverage scoring systems to appeal to competitive-minded players.
- **Certificates:** The goal of the first set of game acts will be to prepare the player to be able to pass the AWS Certified Cloud Practitioner certification exam.
- **Experience Points:** Point scores are not being considered for CHLOE activities. The current philosophy is that the completion of workloads is the primary objective, which is awarded by other means.
- **Achievements:** Achievements are available purely for entertainment and collection purposes.
- **Mastering:** A player has the ability to master CHLOE by completing all game acts.

### Reward Elements

Closely related to achievement, rewards can be added into the learning experience. Both variable and fixed reward schedules are popular game mechanics. Rewards can be based on completing a number of actions, or distributed at set intervals. Rewards provide extrinsic motivation and recognition for time, effort, and skills attained.

- **Rewards:** Rewards are available for both in-person events and in-game accomplishments. In-person events can provide players with single-use codes to enable new meshes for CHLOE, transforming her into different animal types. In-game rewards include customization features for CHLOE (clothing, hats, animations, etc.).

### Story Elements

An adventure setting, a thwarting disaster scenario, or beating the competition narrative pique learner interest and motivation. Put the learning experience into a compelling narrative setting. Add characters, conflicts, and resolution to immerse the learner - and learner choices - into the storyline.

- **Puzzles and Labs:** Each level in CHLOE is designed as a training lab. The technical content of each level is standalone, but labs tie into the cohesive story based on the purpose and tools used.
- **Challenges:** Occasional "world event" style challenges will randomly test the player's skill in a technical area. Community challenges are also being investigated.
- **Replayability:** A primary avenue for replayability is to review content/training as needed by players. To provide the most relevant training, CHLOE will require regular updates to accommodate changes to AWS APIs, which will result in minor changes to levels as time progresses.
- **Exploration Areas:** Simulation mode is the primary exploration area where players are free to do as they please.

### Time Elements

A common trope in board games, timers and countdown clocks create a sense of urgency. Even using a schedule of events helps focus the learner attention on the task at hand.

- **Timed Events:** Timed world events can add a short distraction from the core gameplay loop. This has to be approached with caution, as it can also become a nuisance to players.

### Personalization Elements

From selecting and customizing an avatar to choosing the look and feel options accommodates individual preferences. Use the information from learner input fields. For example, use the learner's nickname within the environment or narrative. Repurpose previous responses to provide a sense of intelligence or awareness.

- **User Profile (Public/Private):** Users should be able to share their profile, badges, and CHLOE customizations. In the spirit of "anyone can be a builder" the player will have a customizable avatar that is part of their public/private profile.
- **Creative Space:** Players should be able to showcase creative solutions as part of community engagement. As an example, community showcase events on Twitch.

### Microinteraction Elements

Provide nuanced environmental reactions to learner actions through sound, subtle animation, and cool transition screens.

- **CHLOE:** Careful detail should be paid to how CHLOE interacts with the game world and the player. As the primary bridge between the player, AWS. and the story, she should represent a cohesive bond between the three. In video games, a good representation of this is the [combat style of Kratos (the player) and Atreus (NPC) in God of War (PS4)](https://www.youtube.com/watch?v=ZTDPx0phrYQ).

### Social Elements

Give players a forum to interact with one another, share ideas, and collaborate.

- **Social/Communication:** Players must have means to communicate with AWS and with one another. Social platforms like Twitch and Discord should be engaged with by the CHLOE community manager.
- **Streaming/Sessions:** As above, CHLOE will leverage a community manager for this purpose.
- **Feedback and Roadmap Influence:** To support players, a roadmap will be provided in a public location so that they can log issues and actively communicate with the development team. See the [AWS CloudFormation coverage roadmap](https://github.com/aws-cloudformation/aws-cloudformation-coverage-roadmap/projects/1) as an example.

## Use Tried and True Concepts

As with non-educational games, there is common guidance that is recommended for any game to be successful in the market. Examples include the following ([source](https://www.gamified.uk/user-types/gamification-mechanics-elements/)).

- On-Boarding/Tutorials
- Signposting
- Loss Aversion
- Progress/Feedback
- Theme
- Narrative/Story
- Curiosity/Mystery Box (not to be confused with "loot boxes" paid for with actual currency)
- Time Pressure
- Scarcity
- Strategy
- Flow
- Consequences
- Investment
- Rewards (Random, Fixed, Time Dependent)
- Socialization (Guilds/Teams, Network, Status, Discovery, Pressure, Competition)
- Freedom (Exploration, Choice, Easter Eggs, Unlockable Content, Creativity Tools, Customization)
- Achievements (Challenges, Certificates, Learning, Quests, Progression, Boss Battles)
- Philanthropy (Meaning/Purpose, Care-Taking, Access, Collection/Trading, Gifting/Sharing, Knowledge Transfer)
- Disruption (Innovation, Voting/Voice, Development Tools, Anonymity, Light Touch, Anarchy)
- Player (XP, Physical Rewards, Leaderboards, Achievements, Virtual Economy, Lottery/Chance)

## Minimize Useless Mental Load

Having to recall "factoid" information such as AWS resource ARNs is an unnecessary requirement on players. CHLOE should focus on streamlining access to this information to prevent the player having to "copy-paste" values.

## Build Real Workloads

Players want to see how a service relates to the rest of the cloud ecosystem; they want to see how to build a single service into a realistic workload.. Engagement in CHLOE should focus on this effort.
