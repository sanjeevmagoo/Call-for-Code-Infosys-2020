# Bend the Curve - Multi-Channel National Crisis Communication Program 2020

[![License](https://img.shields.io/badge/License-Apache2-blue.svg)](https://www.apache.org/licenses/LICENSE-2.0) [![Slack](https://img.shields.io/badge/Join-Slack-blue)](https://callforcode.org/slack) [![Website](https://img.shields.io/badge/View-Website-blue)](https://code-and-response.github.io/Project-Sample/)

This GitHub repository is part of 'Infosys and IBM Hackathon 2020 - Call for Code' submission.

## Contents

1. [Short description](#short-description)
1. [Demo video](#demo-video)
1. [The architecture](#the-architecture)
1. [Long description](#long-description)
1. [Project roadmap](#project-roadmap)
1. [Getting started](#getting-started)
1. [Running the tests](#running-the-tests)
1. [Live demo](#live-demo)
1. [Built with](#built-with)
1. [Contributing](#contributing)
1. [Versioning](#versioning)
1. [Authors](#authors)
1. [License](#license)
1. [Acknowledgments](#acknowledgments)

## Short description

### What's the problem?

In case of any crisis like COVID-19, communication systems are the first to overwhelm, when people are looking for authentic and timely information. As a result, it's the responsibility of the Govt to provide accurate and timely information to it's Citizens. The source of the data must remain the same while consumed from multiple channels so the same information flows regardless of the channel selected by the end-user.

### How can technology help?

Govt can expose the common APIs to be consumed by multiple channels. The wrappers can be developed on top of these APIs, so that multiple channels can be created by innovators. 

Some of the channels we have tried in this Hackathon are:

1. Node.JS Website hosted on IBM Cloud Foundry.
2. Whatsapp - Using Twillo - To reach the masses, Govt has to be on Whatsapp.
3. Twitter - Automated posting of authentic Information on Govt of India Designated Twitter handle.
4. Alexa - Hey Alexa, How many new COVID patients in Delhi today?


### The idea

The efficacy of any crisis communication strategy, especially during public health disasters, depends equally on the accuracy of information disseminated and also its inclusivity. As the term ‘communication’ is expressive in itself, the interpretation and receptivity towards the messaging vary for different groups.

Communication culture must improve from the traditional way because people use multiple channels to find the information. Providing a set of open-source APIs, backed by IBM Cloud and Watson Services, will enable innovators to conveniently make information available to the public, regardless of the selected channel.

## Demo video

[![Watch the video](https://github.com/sanjeevmagoo/Call-for-Code-Infosys-Bend-The-Curve-Team/blob/master/Thumb.JPG)](https://youtu.be/PRoKspmInks)


Some of the channels we have tried in this Hackathon are:

1. Node.JS Website hosted on IBM Cloud Foundry.
2. Whatsapp - Using Twillo - To reach the masses, Govt has to be on Whatsapp.
3. Twitter - Automated posting of authentic Information on Govt of India Designated Twitter handle.
4. Alexa - Hey Alexa, How many new COVID patients in Delhi today?

## The architecture

![Multi-Channel Crisis Communication Program using IBM Cloud Services](https://github.com/sanjeevmagoo/Call-for-Code-Infosys-Bend-The-Curve-Team/blob/master/Solution.jpeg)

1. The user uses multiple Channels to gain authentic COVID information from multiple sources.
2. A combination of IBM services like Watson, Cloud foundry, CICD, Cloud Functions come together to provide seamless information regardless of the selected channel.


## Long description

You can find a running system to test at [Node.js Website](https://covid19test-reflective-quokka-vo.eu-gb.mybluemix.net)

![Whatsapp and Alexa Integration](https://github.com/sanjeevmagoo/Call-for-Code-Infosys-Bend-The-Curve-Team/blob/master/WhatsApp-Alexa.jpeg)
![Twitter Integration](https://github.com/sanjeevmagoo/Call-for-Code-Infosys-Bend-The-Curve-Team/blob/master/Twitter.jpeg)

## Project roadmap

To take it to local Govt agencies for approval and implementation.

## Getting started

Different services need to be set up as per the architecture.

### Prerequisites

IBM Cloud service

## Live demo

You can find a running system to test at [Node.js Website](https://covid19test-reflective-quokka-vo.eu-gb.mybluemix.net)

## Built with

* [IBM Cloud](https://cloud.ibm.com/catalog?search=ibm%20cloud#search_results) - Various IBM Cloud Services
* [IBM Watson](https://cloud.ibm.com/catalog?search=ibm%20watson#search_results) - multi-channel Bot framework
* [IBM Cloud Functions](https://cloud.ibm.com/catalog?search=cloud%20functions#search_results) - The compute platform for handling logic
* [IBM Cloud Foundry](https://cloud.ibm.com/catalog?search=cloud%20foundry#search_results) - The compute platform for hosting applications
* [Twillo](https://www.twilio.com/) - To integrate with Whatsapp
* [Alexa](https://developer.amazon.com/en-GB/alexa/) - To build the conversational app
* [CICD using IBM Cloud Foundry build in services](https://www.ibm.com/in-en/cloud) - To build CICD solution


![Fully CICD Soultion using IBM Services](https://github.com/sanjeevmagoo/Call-for-Code-Infosys-Bend-The-Curve-Team/blob/master/CICD.JPG)

## Contributing

None

## Versioning

None

## Authors

* **Sanjeev Kumar** - Sanjeev_Magoo@infosys.com

## License

This project is licensed under the Apache 2 License - see the [LICENSE](LICENSE) file for details

## Acknowledgments

* IBM Cloud Team that provided the services to host the solution
* Masterhacks for providing the required guidance
* IBM and Infosys teams for coming together for such a wonderful platform for learning and sharing
