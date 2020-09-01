# Digital Twin
Digital Twins have become increasingly popular in the last few years because of their capabilities of influencing design build operations. Digital twin refers to a digital replica of assets in the building, the various rooms and sensors among other entities.  
In our case, building a digital twin of the hospital will help create an environment, which can be controlled by the user and provides additional Insights for effective operation of edge devices. In this context, edge devices refer to the drone and the conversational chat bot.  
There is need to monitor the data from sensors, such as the occupancy sensors, temperature sensors, energy consumption, etc. across the building to get an insight into the various factors affecting the facility, which can effectively be provided by the digital twin.

![digital-twin-contoso-healthcare](Contoso Healthcare.png)

# Suggested solution: 
The digital twin service provided by Azure when paired along with the 3-D visualization of the hospital helps build a digital twin of the facility. 
1.A digital twin of the hospital premises is built, and the management of all sensors across the facility is done with the help of the IoT Hub. The sensor data available via the Azure IoT hub is paired with edge devices and can help provide an overview on aspects such as temperature, occupancy status and more.
2. The mapping of each floor is carried out using 2-D CAD drawings which are further converted into Azure indoor maps using the Creator module.
As mentioned earlier, the digital twin not only provides a visualization of the building, but also provides data to edge devices such as the drone and the conversational chatbot to create additional digital solutions. The edge devices with the help of the Azure indoor maps can help patients with their queries and also navigate around the facility and monitor all aspects such as COVID-19 guidelines, among others. All these aspects combined provides an end to end identical digital model of the physical hospital enabling the ability to test certain technologies and scenarios via simulations prior to implementing it in the real life facility.

# Create the Azure Digital Twin 

To create a new instance of the digital twin, follow the steps on this link: https://docs.microsoft.com/en-us/azure/digital-twins/how-to-set-up-instance-scripted

To create the various sensors in the digital twin, follow this tutorial: https://microsoftlearning.github.io/AZ-220-Microsoft-Azure-IoT-Developer/Instructions/Labs/LAB_AK_15-remotely-monitor-and-control-devices.html#simplified-lab-conditions

This creates the digital twin of the Contoso Healthcare facility.

To visualise the data in a web application, follow this tutorial: https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-live-data-visualization-in-web-apps

# Eventual impact:
The eventual impact of the digital twin will be to gain a realistic simulation of the hospital and its associated entities, along with providing full control of the building to the user, while also providing navigation and other functionalities to edge devices such as the drone, and the conversational bot.
