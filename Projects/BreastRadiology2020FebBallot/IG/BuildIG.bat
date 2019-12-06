copy Content\Graphics\* guide\input\images
copy Content\Resources\* guide\input\resources

@SET JAVA_TOOL_OPTIONS=-Dfile.encoding=UTF-8
pushd guide
JAVA -jar input-cache\org.hl7.fhir.publisher.jar -ig ig.ini

@PAUSE