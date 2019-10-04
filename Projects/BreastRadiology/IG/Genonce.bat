@SET JAVA_TOOL_OPTIONS=-Dfile.encoding=UTF-8
pushd guide\Resources
copy ig-save.xml ig.xml
cd ..

JAVA -jar org.hl7.fhir.publisher.jar -ig ig.json

cd Resources
del ig.json
del ig.xml
popd

@PAUSE