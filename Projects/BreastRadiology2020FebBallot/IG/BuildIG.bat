rem copy Graphics\* guide\pages

copy Resources\* guide\input\resources

@SET JAVA_TOOL_OPTIONS=-Dfile.encoding=UTF-8
pushd guide
JAVA -jar input-cache\org.hl7.fhir.publisher.jar -ig ig.ini

@PAUSE