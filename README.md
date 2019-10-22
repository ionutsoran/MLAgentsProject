# MLAgentsProject
A unity project using the ML Agents toolkit that teaches agents to stabilize themselves in the air at a given height, by just applying a force that should simulate a propeller(no 3D animation yet!).For now instead of a drone with a proper propeller we have a sphere place holder.

The main aim for this work was for the most part just a learning experience, to understand the intrecacies of how reinforcement learning works in simulated environments and what is the state of the art in this particular area of research. Being a Unity enthusiast, this was normally the place to start.

The biggest challenge so far was figuring out a function that rewards the drone agents proportinally by how close or far they are from the target height.The results of the agent reward function is fed back into a <b>Proximal Policy Optimization</b> neural network that uses that information to adjuts its weights and biases. So far this function seems to perform much better than other custom reward functions in other similar projects, in some instances achieving a 5 times faster function aproximation.

Bellow is definition for the set function:
<img src="https://i.imgur.com/5skHeTh.jpg" alt="alt text" width="650" height="220"/> 

Where <b><i>ch</i></b> stands for current height, <b><i>ih</i></b> for ideal height, <b><i>tr</i></b> is a threshold value.

Screenshot of a trained model with 330000 Epoch iterations (Time at which the agents manage to stabilize themselves self on quite strong forces, given a realstic frame of reference).

<img src="https://i.imgur.com/J0H2As0.png" alt="alt text" width="700" height="400" />

Screenshot of a training process in our training environment (A red color means its performin poorly, and a green colors meants its performing good).

<img src="https://i.imgur.com/fMMjEF0.png" alt="alt text" width="700" height="400" />

This project is far from being done, however as a testing ground it serves it's purpose. Planned features include, traning the model on more than on axis and a set destination for the agent to reach while avoiding obstacles.
