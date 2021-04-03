# TheHerd
A model-driven REST API and application for tracking COVID-19 vaccinations and symptoms.

For my SENG 6250 final project, I performed a model to text transformation using the following:

-- Modeling Language: RAML

-- IDE: VS Code for RAML file/API specification, Visual Studio to generate API client

-- Transformation Tool: Mulesoft's API Designer for API specification, Visual Studio extensions (RAML Tools for .NET, RestEase Client Code Generator) for API client

Note that this is a case study of the experience using these tools, challenges, etc. Future work is being done to improve this project, and build errors exist in the current RAMLTransformation.sln.

#####################################

To use Mulesoft's API Designer:


> npm install -g api-designer

(If you don't already have requests installed...)

>npm i -g request

>api-designer


#####################################

To generate API client in Visual Studio with extensions listed above: 

* Right click in Solution Explorer. 
* Click "Add RAML/OAS Contract."
* Upload your RAML file.
* In the "Import RAML/OAS" window that pops up, check the boxes for "Use api version," "Use async methods," "Enable customization." 
* In the "Import RAML/OAS" window that pops up, give your Controllers Folders a name as well as your Models Folder.
* Click the Import button. 
* You should now see the contents of the RAML file in the Solution Explorer. 
* Right click in Solution Explorer. 
* Click "RestEast Client Generator."
* Click "Generate." 

