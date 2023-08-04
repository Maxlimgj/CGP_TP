<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2015/01/31 17:06:33">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="1" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneGroups nextGroupID="4">
        <SceneGroup id="0" />
        <SceneGroup id="1" />
        <SceneGroup id="2" />
        <SceneGroup id="3" />
    </SceneGroups>
    <SceneShapes nextShapeID="2">
        <SceneShape id="0" type="1" entityID="10" dl="0" group="-1" locked="0" />
        <SceneShape id="1" type="1" entityID="11" dl="0" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="12">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="7" classname="portal" gametype="Torque" isPointEntity="0">
                        <Properties ambient_light="0" />
                    </Entity>
                    <Entity id="10" classname="light_flicker" gametype="Torque" isPointEntity="1" origin="5.5 -27.5 -4" direction="0 -0 -0">
                        <Properties name="" speed="2" spawnflags="3" alarm_type="0" color1="255 255 255" color2="0 0 0" color3="0 0 0" color4="0 0 0" color5="0 0 0" falloff1="10" falloff2="100" />
                    </Entity>
                    <Entity id="11" classname="light_flicker" gametype="Torque" isPointEntity="1" origin="49.5 0 3.5" direction="0 -0 -0">
                        <Properties name="" speed="2" spawnflags="3" alarm_type="0" color1="255 255 255" color2="0 0 0" color3="0 0 0" color4="0 0 0" color5="0 0 0" falloff1="10" falloff2="100" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="1821">
                    <Brush id="122" owner="0" type="0" pos="-11.9755 18.2894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.9755 0 1.3 0 18.2894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="151" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6.63315 14.4216 2.5" />
                            <Vertex pos="-6.63315 14.4216 -3.5" />
                            <Vertex pos="-6.63315 12.4216 2.5" />
                            <Vertex pos="-6.63315 12.4216 -3.5" />
                            <Vertex pos="-8.63315 14.4216 2.5" />
                            <Vertex pos="-8.63315 14.4216 -3.5" />
                            <Vertex pos="-8.63315 12.4216 2.5" />
                            <Vertex pos="-8.63315 12.4216 -3.5" />
                        </Vertices>
                        <Face id="144" plane="1 -0 0 6.63315" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="145" plane="-1 0 0 -8.63315" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="146" plane="0 1 -0 -14.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="147" plane="0 -1 0 12.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="148" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="149" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="322" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="277" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.13315 3.42161 -3.5" />
                            <Vertex pos="-3.13315 3.42161 -3.5" />
                            <Vertex pos="-3.13315 3.42161 2.5" />
                            <Vertex pos="-1.13315 3.42161 2.5" />
                            <Vertex pos="-3.13315 5.42161 2.5" />
                            <Vertex pos="-3.13315 5.42161 -3.5" />
                            <Vertex pos="-1.13315 5.42161 2.5" />
                            <Vertex pos="-1.13315 5.42161 -3.5" />
                        </Vertices>
                        <Face id="270" plane="0 -1 0 3.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="271" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="272" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="273" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 5 1" />
                        </Face>
                        <Face id="274" plane="1 0 0 1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="275" plane="0 1 0 -5.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="375" owner="0" type="0" pos="9.47453 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 9.47453 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="703" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.86685 11.4216 -3.5" />
                            <Vertex pos="8.86685 13.4216 -3.5" />
                            <Vertex pos="8.86685 13.4216 2.5" />
                            <Vertex pos="8.86685 11.4216 2.5" />
                            <Vertex pos="10.8668 13.4216 -3.5" />
                            <Vertex pos="10.8668 13.4216 2.5" />
                            <Vertex pos="10.8668 11.4216 2.5" />
                            <Vertex pos="10.8668 11.4216 -3.5" />
                        </Vertices>
                        <Face id="696" plane="-1 0 0 8.86685" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="697" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="698" plane="-0 -1 -0 11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="699" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="700" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="701" plane="1 -0 0 -10.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="377" owner="0" type="0" pos="11.4245 11.7894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 11.4245 0 1.3 0 11.7894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="697" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.36685 7.42161 -3.5" />
                            <Vertex pos="7.36685 9.42161 -3.5" />
                            <Vertex pos="7.36685 9.42161 2.5" />
                            <Vertex pos="7.36685 7.42161 2.5" />
                            <Vertex pos="9.36685 9.42161 -3.5" />
                            <Vertex pos="9.36685 9.42161 2.5" />
                            <Vertex pos="9.36685 7.42161 2.5" />
                            <Vertex pos="9.36685 7.42161 -3.5" />
                        </Vertices>
                        <Face id="690" plane="-1 0 0 7.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="691" plane="0 1 -0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="692" plane="-0 -1 -0 7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="693" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="694" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="695" plane="1 -0 0 -9.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="405" owner="0" type="0" pos="9.47453 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 9.47453 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="709" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10.8668 11.4216 -3.5" />
                            <Vertex pos="10.8668 13.4216 -3.5" />
                            <Vertex pos="10.8668 13.4216 2.5" />
                            <Vertex pos="10.8668 11.4216 2.5" />
                            <Vertex pos="16.8668 13.4216 -3.5" />
                            <Vertex pos="16.8668 13.4216 2.5" />
                            <Vertex pos="16.8668 11.4216 2.5" />
                            <Vertex pos="16.8668 11.4216 -3.5" />
                        </Vertices>
                        <Face id="702" plane="-1 0 0 10.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="703" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="704" plane="-0 -1 -0 11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="705" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="706" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="707" plane="1 -0 0 -16.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="407" owner="0" type="0" pos="11.4245 11.7894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 11.4245 0 1.3 0 11.7894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="703" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="9.36685 7.42161 -3.5" />
                            <Vertex pos="9.36685 9.42161 -3.5" />
                            <Vertex pos="9.36685 9.42161 2.5" />
                            <Vertex pos="9.36685 7.42161 2.5" />
                            <Vertex pos="15.3668 9.42161 -3.5" />
                            <Vertex pos="15.3668 9.42161 2.5" />
                            <Vertex pos="15.3668 7.42161 2.5" />
                            <Vertex pos="15.3668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="696" plane="-1 0 0 9.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="697" plane="0 1 -0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="698" plane="-0 -1 -0 7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="699" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="700" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="701" plane="1 -0 0 -15.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="415" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="17.3668 2.42161 -3.5" />
                            <Vertex pos="17.3668 4.42161 -3.5" />
                            <Vertex pos="17.3668 4.42161 2.5" />
                            <Vertex pos="17.3668 2.42161 2.5" />
                            <Vertex pos="23.3668 4.42161 -3.5" />
                            <Vertex pos="23.3668 4.42161 2.5" />
                            <Vertex pos="23.3668 2.42161 2.5" />
                            <Vertex pos="23.3668 2.42161 -3.5" />
                        </Vertices>
                        <Face id="384" plane="-1 0 0 17.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="385" plane="0 1 -0 -4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="386" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="387" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="388" plane="-0 -1 -0 2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="389" plane="1 -0 0 -23.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="417" owner="0" type="0" pos="17.2745 6.58937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.2745 0 1.3 0 6.58937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="379" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10.8668 3.42161 -3.5" />
                            <Vertex pos="10.8668 5.42161 -3.5" />
                            <Vertex pos="10.8668 5.42161 2.5" />
                            <Vertex pos="10.8668 3.42161 2.5" />
                            <Vertex pos="12.8668 5.42161 -3.5" />
                            <Vertex pos="12.8668 5.42161 2.5" />
                            <Vertex pos="12.8668 3.42161 2.5" />
                            <Vertex pos="12.8668 3.42161 -3.5" />
                        </Vertices>
                        <Face id="372" plane="-1 0 0 10.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="373" plane="0 1 -0 -5.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 64 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="374" plane="0 -1 0 3.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 64 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="375" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 64 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="376" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 64 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="377" plane="1 -0 0 -12.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 64 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="418" owner="0" type="0" pos="17.2745 6.58937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.2745 0 1.3 0 6.58937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="379" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="18.8668 3.42161 -3.5" />
                            <Vertex pos="18.8668 3.42161 2.5" />
                            <Vertex pos="18.8668 5.42161 2.5" />
                            <Vertex pos="18.8668 5.42161 -3.5" />
                            <Vertex pos="12.8668 5.42161 -3.5" />
                            <Vertex pos="12.8668 5.42161 2.5" />
                            <Vertex pos="12.8668 3.42161 2.5" />
                            <Vertex pos="12.8668 3.42161 -3.5" />
                        </Vertices>
                        <Face id="372" plane="1 -0 0 -18.8668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="373" plane="0 1 -0 -5.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 64 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="374" plane="-0 -1 -0 3.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 64 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="375" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 64 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="376" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 64 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="377" plane="-1 0 0 12.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 64 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="425" owner="0" type="0" pos="9.47453 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 9.47453 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="715" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="16.8668 11.4216 -3.5" />
                            <Vertex pos="16.8668 13.4216 -3.5" />
                            <Vertex pos="16.8668 13.4216 2.5" />
                            <Vertex pos="16.8668 11.4216 2.5" />
                            <Vertex pos="18.8668 13.4216 -3.5" />
                            <Vertex pos="18.8668 13.4216 2.5" />
                            <Vertex pos="18.8668 11.4216 2.5" />
                            <Vertex pos="18.8668 11.4216 -3.5" />
                        </Vertices>
                        <Face id="708" plane="-1 0 0 16.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="709" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="710" plane="-0 -1 -0 11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="711" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="712" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="713" plane="1 -0 0 -18.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="426" owner="0" type="0" pos="9.47453 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 9.47453 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="715" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="22.8668 11.4216 -3.5" />
                            <Vertex pos="22.8668 11.4216 2.5" />
                            <Vertex pos="22.8668 13.4216 2.5" />
                            <Vertex pos="22.8668 13.4216 -3.5" />
                            <Vertex pos="18.8668 13.4216 -3.5" />
                            <Vertex pos="18.8668 13.4216 2.5" />
                            <Vertex pos="18.8668 11.4216 2.5" />
                            <Vertex pos="18.8668 11.4216 -3.5" />
                        </Vertices>
                        <Face id="708" plane="1 -0 0 -22.8668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="709" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="710" plane="-0 -1 -0 11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="711" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="712" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="713" plane="-1 0 0 18.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="427" owner="0" type="0" pos="11.4245 11.7894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 11.4245 0 1.3 0 11.7894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="709" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="15.3668 7.42161 -3.5" />
                            <Vertex pos="15.3668 9.42161 -3.5" />
                            <Vertex pos="15.3668 9.42161 2.5" />
                            <Vertex pos="15.3668 7.42161 2.5" />
                            <Vertex pos="17.3668 9.42161 -3.5" />
                            <Vertex pos="17.3668 9.42161 2.5" />
                            <Vertex pos="17.3668 7.42161 2.5" />
                            <Vertex pos="17.3668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="702" plane="-1 0 0 15.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="703" plane="0 1 -0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="704" plane="-0 -1 -0 7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="705" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="706" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="707" plane="1 -0 0 -17.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="428" owner="0" type="0" pos="11.4245 11.7894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 11.4245 0 1.3 0 11.7894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="709" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="23.3668 7.42161 -3.5" />
                            <Vertex pos="23.3668 7.42161 2.5" />
                            <Vertex pos="23.3668 9.42161 2.5" />
                            <Vertex pos="23.3668 9.42161 -3.5" />
                            <Vertex pos="17.3668 9.42161 -3.5" />
                            <Vertex pos="17.3668 9.42161 2.5" />
                            <Vertex pos="17.3668 7.42161 2.5" />
                            <Vertex pos="17.3668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="702" plane="1 -0 0 -23.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="703" plane="0 1 -0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="704" plane="-0 -1 -0 7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="705" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="706" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="707" plane="-1 0 0 17.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="439" owner="0" type="0" pos="7.52453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 7.52453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="265" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.36685 1.92161 -3.5" />
                            <Vertex pos="8.36685 1.92161 -3.5" />
                            <Vertex pos="8.36685 1.92161 2.5" />
                            <Vertex pos="6.36685 1.92161 2.5" />
                            <Vertex pos="8.36685 -0.0783901 2.5" />
                            <Vertex pos="8.36685 -0.0783901 -3.5" />
                            <Vertex pos="6.36685 -0.0783901 -3.5" />
                            <Vertex pos="6.36685 -0.0783901 2.5" />
                        </Vertices>
                        <Face id="258" plane="0 1 -0 -1.92161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="259" plane="1 0 0 -8.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="260" plane="-1 0 0 6.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="261" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="262" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="263" plane="-0 -1 -0 -0.0783901" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="445" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="229" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.86685 3.42161 -3.5" />
                            <Vertex pos="4.86685 3.42161 -3.5" />
                            <Vertex pos="4.86685 3.42161 2.5" />
                            <Vertex pos="2.86685 3.42161 2.5" />
                            <Vertex pos="4.86685 -0.57839 2.5" />
                            <Vertex pos="4.86685 -0.57839 -3.5" />
                            <Vertex pos="2.86685 -0.57839 2.5" />
                            <Vertex pos="2.86685 -0.57839 -3.5" />
                        </Vertices>
                        <Face id="222" plane="0 1 -0 -3.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="223" plane="1 0 0 -4.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="224" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="225" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="226" plane="-1 0 0 2.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="227" plane="0 -1 0 -0.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="449" owner="0" type="0" pos="4.92453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 4.92453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="625" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.36685 1.92161 2.5" />
                            <Vertex pos="4.36685 1.92161 -3.5" />
                            <Vertex pos="6.36685 1.92161 -3.5" />
                            <Vertex pos="6.36685 1.92161 2.5" />
                            <Vertex pos="6.36685 -0.0783899 2.5" />
                            <Vertex pos="6.36685 -0.0783902 -3.5" />
                            <Vertex pos="4.36685 -0.0783899 -3.5" />
                            <Vertex pos="4.36685 -0.0783902 2.5" />
                        </Vertices>
                        <Face id="618" plane="0 1 0 -1.92161" album="MyAlbum" material="images (3)" texgens="-1 0 0 96 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="619" plane="1 0 0 -6.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 96 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="620" plane="-1 0 0 4.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 96 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="621" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="622" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="623" plane="1.52737e-007 -1 5.09123e-008 -0.078391" album="MyAlbum" material="images (3)" texgens="-1 0 0 96 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="451" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="283" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.13315 1.42161 -3.5" />
                            <Vertex pos="-1.13315 1.42161 2.5" />
                            <Vertex pos="-3.13315 1.42161 2.5" />
                            <Vertex pos="-3.13315 1.42161 -3.5" />
                            <Vertex pos="-3.13315 -0.57839 2.5" />
                            <Vertex pos="-3.13315 -0.57839 -3.5" />
                            <Vertex pos="-1.13315 -0.57839 2.5" />
                            <Vertex pos="-1.13315 -0.57839 -3.5" />
                        </Vertices>
                        <Face id="276" plane="0 1 0 -1.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="277" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="278" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="279" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="280" plane="1 0 0 1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="281" plane="0 -1 0 -0.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="453" owner="0" type="0" pos="7.52453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 7.52453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="271" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.36685 -2.07839 -3.5" />
                            <Vertex pos="6.36685 -0.0783901 -3.5" />
                            <Vertex pos="6.36685 -0.0783901 2.5" />
                            <Vertex pos="6.36685 -2.07839 2.5" />
                            <Vertex pos="18.3668 -2.07839 2.5" />
                            <Vertex pos="18.3668 -2.07839 -3.5" />
                            <Vertex pos="18.3668 -0.0783901 2.5" />
                            <Vertex pos="18.3668 -0.0783901 -3.5" />
                        </Vertices>
                        <Face id="264" plane="-1 0 0 6.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="265" plane="0 -1 0 -2.07839" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="266" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 4" />
                        </Face>
                        <Face id="267" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="268" plane="0 1 0 0.0783901" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 7 6" />
                        </Face>
                        <Face id="269" plane="1 0 0 -18.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="456" owner="0" type="0" pos="7.52453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 7.52453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="277" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.36685 -10.0784 2.5" />
                            <Vertex pos="20.3668 -10.0784 2.5" />
                            <Vertex pos="20.3668 -10.0784 -3.5" />
                            <Vertex pos="8.36685 -10.0784 -3.5" />
                            <Vertex pos="20.3668 -8.07839 2.5" />
                            <Vertex pos="20.3668 -8.07839 -3.5" />
                            <Vertex pos="8.36685 -8.07839 2.5" />
                            <Vertex pos="8.36685 -8.07839 -3.5" />
                        </Vertices>
                        <Face id="270" plane="-0 -1 -0 -10.0784" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="271" plane="1 -0 0 -20.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="272" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="273" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="274" plane="-1 0 0 8.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="275" plane="0 1 -0 8.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="459" owner="0" type="0" pos="4.92453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 4.92453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="613" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.36685 -6.07839 -3.5" />
                            <Vertex pos="4.36685 -4.07839 -3.5" />
                            <Vertex pos="4.36685 -4.07839 2.5" />
                            <Vertex pos="4.36685 -6.07839 2.5" />
                            <Vertex pos="6.36685 -6.07839 2.5" />
                            <Vertex pos="6.36685 -6.07839 -3.5" />
                            <Vertex pos="6.36685 -4.07839 2.5" />
                            <Vertex pos="6.36685 -4.07839 -3.5" />
                        </Vertices>
                        <Face id="606" plane="-1 0 0 4.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 96 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="607" plane="0 -1 0 -6.07839" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="608" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 4" />
                        </Face>
                        <Face id="609" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="610" plane="0 1 0 4.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 96 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 7 6" />
                        </Face>
                        <Face id="611" plane="1 0 0 -6.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="467" owner="0" type="0" pos="11.4245 11.7894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 11.4245 0 1.3 0 11.7894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="697" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.63315 7.42161 -3.5" />
                            <Vertex pos="-2.63315 9.42161 -3.5" />
                            <Vertex pos="-2.63315 9.42161 2.5" />
                            <Vertex pos="-2.63315 7.42161 2.5" />
                            <Vertex pos="1.36685 9.42161 -3.5" />
                            <Vertex pos="1.36685 9.42161 2.5" />
                            <Vertex pos="1.36685 7.42161 2.5" />
                            <Vertex pos="1.36685 7.42161 -3.5" />
                        </Vertices>
                        <Face id="690" plane="-1 0 0 -2.63315" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="691" plane="0 1 -0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="692" plane="0 -1 0 7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="693" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="694" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="695" plane="1 -0 0 -1.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="493" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="283" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.86685 7.42161 -3.5" />
                            <Vertex pos="8.86685 9.42161 -3.5" />
                            <Vertex pos="8.86685 9.42161 2.5" />
                            <Vertex pos="8.86685 7.42161 2.5" />
                            <Vertex pos="10.8668 9.42161 2.5" />
                            <Vertex pos="10.8668 9.42161 -3.5" />
                            <Vertex pos="10.8668 7.42161 2.5" />
                            <Vertex pos="10.8668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="276" plane="-1 0 0 8.86685" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="277" plane="-0 1 0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="278" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="279" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="280" plane="0 -1 0 7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="281" plane="1 -0 0 -10.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="494" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="283" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="20.8668 9.42161 -3.5" />
                            <Vertex pos="20.8668 7.42161 -3.5" />
                            <Vertex pos="20.8668 7.42161 2.5" />
                            <Vertex pos="20.8668 9.42161 2.5" />
                            <Vertex pos="10.8668 9.42161 2.5" />
                            <Vertex pos="10.8668 9.42161 -3.5" />
                            <Vertex pos="10.8668 7.42161 2.5" />
                            <Vertex pos="10.8668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="276" plane="1 0 0 -20.8668" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="277" plane="0 1 0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="278" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="279" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 5 7" />
                        </Face>
                        <Face id="280" plane="0 -1 0 7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="281" plane="-1 0 0 10.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="497" owner="0" type="0" pos="9.47453 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 9.47453 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="709" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.86685 11.4216 -3.5" />
                            <Vertex pos="2.86685 13.4216 -3.5" />
                            <Vertex pos="2.86685 13.4216 2.5" />
                            <Vertex pos="2.86685 11.4216 2.5" />
                            <Vertex pos="4.86685 13.4216 -3.5" />
                            <Vertex pos="4.86685 13.4216 2.5" />
                            <Vertex pos="4.86685 11.4216 2.5" />
                            <Vertex pos="4.86685 11.4216 -3.5" />
                        </Vertices>
                        <Face id="702" plane="-1 0 0 2.86685" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="703" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="704" plane="-0 -1 -0 11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="705" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="706" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="707" plane="1 -0 0 -4.86685" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="498" owner="0" type="0" pos="9.47453 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 9.47453 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="709" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.86685 11.4216 -3.5" />
                            <Vertex pos="8.86685 11.4216 2.5" />
                            <Vertex pos="8.86685 13.4216 2.5" />
                            <Vertex pos="8.86685 13.4216 -3.5" />
                            <Vertex pos="4.86685 13.4216 -3.5" />
                            <Vertex pos="4.86685 13.4216 2.5" />
                            <Vertex pos="4.86685 11.4216 2.5" />
                            <Vertex pos="4.86685 11.4216 -3.5" />
                        </Vertices>
                        <Face id="702" plane="1 -0 0 -8.86685" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="703" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="704" plane="-0 -1 -0 11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="705" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="706" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="707" plane="-1 0 0 4.86685" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="499" owner="0" type="0" pos="11.4245 11.7894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 11.4245 0 1.3 0 11.7894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="703" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.36685 7.42161 -3.5" />
                            <Vertex pos="1.36685 9.42161 -3.5" />
                            <Vertex pos="1.36685 9.42161 2.5" />
                            <Vertex pos="1.36685 7.42161 2.5" />
                            <Vertex pos="3.36685 9.42161 -3.5" />
                            <Vertex pos="3.36685 9.42161 2.5" />
                            <Vertex pos="3.36685 7.42161 2.5" />
                            <Vertex pos="3.36685 7.42161 -3.5" />
                        </Vertices>
                        <Face id="696" plane="-1 0 0 1.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="697" plane="0 1 -0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="698" plane="-0 -1 -0 7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="699" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="700" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="701" plane="1 -0 0 -3.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="500" owner="0" type="0" pos="11.4245 11.7894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 11.4245 0 1.3 0 11.7894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="703" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.36685 7.42161 -3.5" />
                            <Vertex pos="7.36685 7.42161 2.5" />
                            <Vertex pos="7.36685 9.42161 2.5" />
                            <Vertex pos="7.36685 9.42161 -3.5" />
                            <Vertex pos="3.36685 9.42161 -3.5" />
                            <Vertex pos="3.36685 9.42161 2.5" />
                            <Vertex pos="3.36685 7.42161 2.5" />
                            <Vertex pos="3.36685 7.42161 -3.5" />
                        </Vertices>
                        <Face id="696" plane="1 -0 0 -7.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="697" plane="0 1 -0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="698" plane="-0 -1 -0 7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="699" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="700" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 208 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="701" plane="-1 0 0 3.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 208 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="507" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.36685 2.42161 -3.5" />
                            <Vertex pos="3.36685 4.42161 -3.5" />
                            <Vertex pos="3.36685 4.42161 2.5" />
                            <Vertex pos="3.36685 2.42161 2.5" />
                            <Vertex pos="11.3668 4.42161 -3.5" />
                            <Vertex pos="11.3668 4.42161 2.5" />
                            <Vertex pos="11.3668 2.42161 2.5" />
                            <Vertex pos="11.3668 2.42161 -3.5" />
                        </Vertices>
                        <Face id="384" plane="-1 0 0 3.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="385" plane="0 1 -0 -4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="386" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="387" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="388" plane="-0 -1 -0 2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="389" plane="1 -0 0 -11.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="508" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="15.3668 2.42161 -3.5" />
                            <Vertex pos="15.3668 2.42161 2.5" />
                            <Vertex pos="15.3668 4.42161 2.5" />
                            <Vertex pos="15.3668 4.42161 -3.5" />
                            <Vertex pos="11.3668 4.42161 -3.5" />
                            <Vertex pos="11.3668 4.42161 2.5" />
                            <Vertex pos="11.3668 2.42161 2.5" />
                            <Vertex pos="11.3668 2.42161 -3.5" />
                        </Vertices>
                        <Face id="384" plane="1 -0 0 -15.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="385" plane="0 1 -0 -4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="386" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="387" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="388" plane="-0 -1 -0 2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="389" plane="-1 0 0 11.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="553" owner="0" type="0" pos="3.62453 -19.4106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 3.62453 0 1.3 0 -19.4106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="403" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.36685 -12.5784 -3.5" />
                            <Vertex pos="5.36685 -12.5784 -3.5" />
                            <Vertex pos="5.36685 -12.5784 2.5" />
                            <Vertex pos="3.36685 -12.5784 2.5" />
                            <Vertex pos="5.36685 -14.5784 2.5" />
                            <Vertex pos="5.36685 -14.5784 -3.5" />
                            <Vertex pos="3.36685 -14.5784 -3.5" />
                            <Vertex pos="3.36685 -14.5784 2.5" />
                        </Vertices>
                        <Face id="396" plane="0 1 -0 12.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="397" plane="1 0 0 -5.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="398" plane="-1 0 0 3.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="399" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="400" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="401" plane="-0 -1 -0 -14.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="557" owner="0" type="0" pos="17.9245 -18.1106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.9245 0 1.3 0 -18.1106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="607" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.3668 -13.5784 2.5" />
                            <Vertex pos="14.3668 -13.5784 -3.5" />
                            <Vertex pos="16.3668 -13.5784 -3.5" />
                            <Vertex pos="16.3668 -13.5784 2.5" />
                            <Vertex pos="16.3668 -15.5784 2.5" />
                            <Vertex pos="16.3668 -15.5784 -3.5" />
                            <Vertex pos="14.3668 -15.5784 -3.5" />
                            <Vertex pos="14.3668 -15.5784 2.5" />
                        </Vertices>
                        <Face id="600" plane="0 1 0 13.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="601" plane="1 0 0 -16.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="602" plane="-1 0 0 14.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="603" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="604" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="605" plane="-0 -1 -0 -15.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="570" owner="0" type="0" pos="3.62453 -15.5106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 3.62453 0 1.3 0 -15.5106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="433" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.36685 -15.5784 -3.5" />
                            <Vertex pos="3.36685 -15.5784 2.5" />
                            <Vertex pos="5.36685 -15.5784 2.5" />
                            <Vertex pos="5.36685 -15.5784 -3.5" />
                            <Vertex pos="5.36685 -13.5784 2.5" />
                            <Vertex pos="5.36685 -13.5784 -3.5" />
                            <Vertex pos="3.36685 -13.5784 -3.5" />
                            <Vertex pos="3.36685 -13.5784 2.5" />
                        </Vertices>
                        <Face id="426" plane="0 -1 0 -15.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="427" plane="1 -0 0 -5.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="428" plane="-1 0 0 3.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="429" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="430" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="431" plane="0 1 0 13.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="571" owner="0" type="0" pos="17.9245 -18.1106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.9245 0 1.3 0 -18.1106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="607" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.3668 -9.57836 -3.5" />
                            <Vertex pos="16.3668 -9.57836 -3.5" />
                            <Vertex pos="16.3668 -9.57836 2.5" />
                            <Vertex pos="0.3668 -9.57836 2.5" />
                            <Vertex pos="16.3668 -11.5784 2.5" />
                            <Vertex pos="16.3668 -11.5784 -3.5" />
                            <Vertex pos="0.3668 -11.5784 -3.5" />
                            <Vertex pos="0.3668 -11.5784 2.5" />
                        </Vertices>
                        <Face id="600" plane="0 1 -0 9.57836" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="601" plane="1 0 0 -16.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="602" plane="-1 0 0 0.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="603" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="604" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="605" plane="-0 -1 -0 -11.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="572" owner="0" type="0" pos="17.9245 -18.1106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.9245 0 1.3 0 -18.1106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="607" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.3668 -13.5784 2.5" />
                            <Vertex pos="16.3668 -13.5784 2.5" />
                            <Vertex pos="16.3668 -13.5784 -3.5" />
                            <Vertex pos="14.3668 -13.5784 -3.5" />
                            <Vertex pos="16.3668 -11.5784 2.5" />
                            <Vertex pos="16.3668 -11.5784 -3.5" />
                            <Vertex pos="14.3668 -11.5784 -3.5" />
                            <Vertex pos="14.3668 -11.5784 2.5" />
                        </Vertices>
                        <Face id="600" plane="-0 -1 -0 -13.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="601" plane="1 0 0 -16.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="602" plane="-1 0 0 14.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="603" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="604" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="605" plane="0 1 0 11.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="584" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="343" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="17.8668 -19.5784 -3.5" />
                            <Vertex pos="15.8668 -19.5784 -3.5" />
                            <Vertex pos="15.8668 -19.5784 2.5" />
                            <Vertex pos="17.8668 -19.5784 2.5" />
                            <Vertex pos="15.8668 -17.5784 -3.5" />
                            <Vertex pos="15.8668 -17.5784 2.5" />
                            <Vertex pos="17.8668 -17.5784 2.5" />
                            <Vertex pos="17.8668 -17.5784 -3.5" />
                        </Vertices>
                        <Face id="336" plane="0 -1 0 -19.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="337" plane="-1 0 0 15.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="338" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="339" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="340" plane="1 0 0 -17.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="341" plane="0 1 0 17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="585" owner="0" type="0" pos="3.62453 -19.4106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 3.62453 0 1.3 0 -19.4106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="409" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.36685 -14.5784 2.5" />
                            <Vertex pos="3.36685 -14.5784 -3.5" />
                            <Vertex pos="5.36685 -14.5784 -3.5" />
                            <Vertex pos="5.36685 -14.5784 2.5" />
                            <Vertex pos="5.36685 -16.5784 2.5" />
                            <Vertex pos="5.36685 -16.5784 -3.5" />
                            <Vertex pos="3.36685 -16.5784 -3.5" />
                            <Vertex pos="3.36685 -16.5784 2.5" />
                        </Vertices>
                        <Face id="402" plane="0 1 0 14.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="403" plane="1 0 0 -5.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="404" plane="-1 0 0 3.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="405" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="406" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="407" plane="-0 -1 -0 -16.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="586" owner="0" type="0" pos="3.62453 -19.4106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 3.62453 0 1.3 0 -19.4106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="409" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10.6332 -18.5784 -3.5" />
                            <Vertex pos="-10.6332 -18.5784 2.5" />
                            <Vertex pos="5.36685 -18.5784 2.5" />
                            <Vertex pos="5.36685 -18.5784 -3.5" />
                            <Vertex pos="5.36685 -16.5784 2.5" />
                            <Vertex pos="5.36685 -16.5784 -3.5" />
                            <Vertex pos="-10.6332 -16.5784 -3.5" />
                            <Vertex pos="-10.6332 -16.5784 2.5" />
                        </Vertices>
                        <Face id="402" plane="0 -1 0 -18.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="403" plane="1 -0 0 -5.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="404" plane="-1 0 0 -10.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="405" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="406" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="407" plane="0 1 0 16.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="589" owner="0" type="0" pos="17.9245 -18.1106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.9245 0 1.3 0 -18.1106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="613" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.3668 -15.5784 2.5" />
                            <Vertex pos="14.3668 -15.5784 -3.5" />
                            <Vertex pos="16.3668 -15.5784 -3.5" />
                            <Vertex pos="16.3668 -15.5784 2.5" />
                            <Vertex pos="16.3668 -17.5784 2.5" />
                            <Vertex pos="16.3668 -17.5784 -3.5" />
                            <Vertex pos="14.3668 -17.5784 -3.5" />
                            <Vertex pos="14.3668 -17.5784 2.5" />
                        </Vertices>
                        <Face id="606" plane="0 1 0 15.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="607" plane="1 0 0 -16.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="608" plane="-1 0 0 14.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="609" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="610" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="611" plane="-0 -1 -0 -17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="590" owner="0" type="0" pos="17.9245 -18.1106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.9245 0 1.3 0 -18.1106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="613" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.3668 -19.5784 -3.5" />
                            <Vertex pos="0.3668 -19.5784 2.5" />
                            <Vertex pos="16.3668 -19.5784 2.5" />
                            <Vertex pos="16.3668 -19.5784 -3.5" />
                            <Vertex pos="16.3668 -17.5784 2.5" />
                            <Vertex pos="16.3668 -17.5784 -3.5" />
                            <Vertex pos="0.3668 -17.5784 -3.5" />
                            <Vertex pos="0.3668 -17.5784 2.5" />
                        </Vertices>
                        <Face id="606" plane="0 -1 0 -19.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="607" plane="1 -0 0 -16.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="608" plane="-1 0 0 0.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="609" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="610" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="611" plane="0 1 0 17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="599" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="349" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="17.8668 -21.5784 -3.5" />
                            <Vertex pos="17.8668 -21.5784 2.5" />
                            <Vertex pos="15.8668 -21.5784 2.5" />
                            <Vertex pos="15.8668 -21.5784 -3.5" />
                            <Vertex pos="15.8668 -23.5784 -3.5" />
                            <Vertex pos="15.8668 -23.5784 2.5" />
                            <Vertex pos="17.8668 -23.5784 2.5" />
                            <Vertex pos="17.8668 -23.5784 -3.5" />
                        </Vertices>
                        <Face id="342" plane="0 1 0 21.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="343" plane="-1 0 0 15.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="344" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="345" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="346" plane="1 0 0 -17.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="347" plane="0 -1 0 -23.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="600" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="349" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="15.8668 -25.5784 2.5" />
                            <Vertex pos="17.8668 -25.5784 2.5" />
                            <Vertex pos="17.8668 -25.5784 -3.5" />
                            <Vertex pos="15.8668 -25.5784 -3.5" />
                            <Vertex pos="15.8668 -23.5784 -3.5" />
                            <Vertex pos="15.8668 -23.5784 2.5" />
                            <Vertex pos="17.8668 -23.5784 2.5" />
                            <Vertex pos="17.8668 -23.5784 -3.5" />
                        </Vertices>
                        <Face id="342" plane="-0 -1 -0 -25.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="343" plane="-1 0 0 15.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="344" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 5" />
                        </Face>
                        <Face id="345" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 7 4" />
                        </Face>
                        <Face id="346" plane="1 -0 0 -17.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 6 7" />
                        </Face>
                        <Face id="347" plane="0 1 0 23.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="624" owner="0" type="0" pos="3.62453 -15.5106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 3.62453 0 1.3 0 -15.5106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="439" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.36685 -13.5784 2.5" />
                            <Vertex pos="5.36685 -13.5784 2.5" />
                            <Vertex pos="5.36685 -13.5784 -3.5" />
                            <Vertex pos="3.36685 -13.5784 -3.5" />
                            <Vertex pos="5.36685 -11.5784 2.5" />
                            <Vertex pos="5.36685 -11.5784 -3.5" />
                            <Vertex pos="3.36685 -11.5784 -3.5" />
                            <Vertex pos="3.36685 -11.5784 2.5" />
                        </Vertices>
                        <Face id="432" plane="-0 -1 -0 -13.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="433" plane="1 0 0 -5.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="434" plane="-1 0 0 3.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="435" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="436" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="437" plane="0 1 0 11.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="635" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="349" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="17.8668 -13.5784 -3.5" />
                            <Vertex pos="17.8668 -13.5784 2.5" />
                            <Vertex pos="15.8668 -13.5784 2.5" />
                            <Vertex pos="15.8668 -13.5784 -3.5" />
                            <Vertex pos="15.8668 -15.5784 -3.5" />
                            <Vertex pos="15.8668 -15.5784 2.5" />
                            <Vertex pos="17.8668 -15.5784 2.5" />
                            <Vertex pos="17.8668 -15.5784 -3.5" />
                        </Vertices>
                        <Face id="342" plane="0 1 0 13.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="343" plane="-1 0 0 15.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="344" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="345" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="346" plane="1 0 0 -17.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="347" plane="0 -1 0 -15.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="636" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="349" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="17.8668 -17.5784 -3.5" />
                            <Vertex pos="15.8668 -17.5784 -3.5" />
                            <Vertex pos="15.8668 -17.5784 2.5" />
                            <Vertex pos="17.8668 -17.5784 2.5" />
                            <Vertex pos="15.8668 -15.5784 -3.5" />
                            <Vertex pos="15.8668 -15.5784 2.5" />
                            <Vertex pos="17.8668 -15.5784 2.5" />
                            <Vertex pos="17.8668 -15.5784 -3.5" />
                        </Vertices>
                        <Face id="342" plane="0 -1 0 -17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="343" plane="-1 0 0 15.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="344" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="345" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="346" plane="1 0 0 -17.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="347" plane="0 1 0 15.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="669" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="313" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.13315 -21.5784 -3.5" />
                            <Vertex pos="-7.13315 -21.5784 -3.5" />
                            <Vertex pos="-7.13315 -21.5784 2.5" />
                            <Vertex pos="-9.13315 -21.5784 2.5" />
                            <Vertex pos="-9.13315 -25.5784 2.5" />
                            <Vertex pos="-9.13315 -25.5784 -3.5" />
                            <Vertex pos="-7.13315 -25.5784 2.5" />
                            <Vertex pos="-7.13315 -25.5784 -3.5" />
                        </Vertices>
                        <Face id="306" plane="0 1 -0 21.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="307" plane="-1 0 0 -9.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="308" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="309" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 1 0 5" />
                        </Face>
                        <Face id="310" plane="1 0 0 7.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="311" plane="0 -1 0 -25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="753" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="403" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="25.3668 2.42161 -3.5" />
                            <Vertex pos="25.3668 4.42161 -3.5" />
                            <Vertex pos="25.3668 4.42161 2.5" />
                            <Vertex pos="25.3668 2.42161 2.5" />
                            <Vertex pos="31.3668 4.42161 -3.5" />
                            <Vertex pos="31.3668 4.42161 2.5" />
                            <Vertex pos="31.3668 2.42161 2.5" />
                            <Vertex pos="31.3668 2.42161 -3.5" />
                        </Vertices>
                        <Face id="396" plane="-1 0 0 25.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="397" plane="0 1 -0 -4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="398" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="399" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="400" plane="-0 -1 -0 2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="401" plane="1 -0 0 -31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="798" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="427" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="33.3668 -39.5784 2.5" />
                            <Vertex pos="33.3668 -37.5784 2.5" />
                            <Vertex pos="33.3668 -37.5784 -3.5" />
                            <Vertex pos="33.3668 -39.5784 -3.5" />
                            <Vertex pos="31.3668 -39.5784 2.5" />
                            <Vertex pos="31.3668 -39.5784 -3.5" />
                            <Vertex pos="31.3668 -37.5784 2.5" />
                            <Vertex pos="31.3668 -37.5784 -3.5" />
                        </Vertices>
                        <Face id="420" plane="1 0 0 -33.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="421" plane="-0 -1 -0 -39.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="422" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="423" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 7 5" />
                        </Face>
                        <Face id="424" plane="0 1 -0 37.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="425" plane="-1 -0 -0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="811" owner="0" type="0" pos="-17.8255 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -17.8255 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="331" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10.1332 11.4216 -3.5" />
                            <Vertex pos="-10.1332 11.4216 2.5" />
                            <Vertex pos="-10.1332 13.4216 2.5" />
                            <Vertex pos="-10.1332 13.4216 -3.5" />
                            <Vertex pos="-12.1332 13.4216 -3.5" />
                            <Vertex pos="-12.1332 13.4216 2.5" />
                            <Vertex pos="-12.1332 11.4216 2.5" />
                            <Vertex pos="-12.1332 11.4216 -3.5" />
                        </Vertices>
                        <Face id="324" plane="1 -0 0 10.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="325" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="326" plane="-0 -1 -0 11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="327" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="328" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="329" plane="-1 0 0 -12.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="879" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="445" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-28.6332 -37.5784 -3.5" />
                            <Vertex pos="-28.6332 -39.5784 -3.5" />
                            <Vertex pos="-28.6332 -39.5784 2.5" />
                            <Vertex pos="-28.6332 -37.5784 2.5" />
                            <Vertex pos="-30.6332 -39.5784 2.5" />
                            <Vertex pos="-30.6332 -39.5784 -3.5" />
                            <Vertex pos="-30.6332 -37.5784 2.5" />
                            <Vertex pos="-30.6332 -37.5784 -3.5" />
                        </Vertices>
                        <Face id="438" plane="1 0 0 28.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="439" plane="-0 -1 -0 -39.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="440" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="441" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 5 1" />
                        </Face>
                        <Face id="442" plane="0 1 -0 37.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="443" plane="-1 -0 -0 -30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="939" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="15.3668 0.42161 2.5" />
                            <Vertex pos="17.3668 0.42161 2.5" />
                            <Vertex pos="17.3668 0.42161 -3.5" />
                            <Vertex pos="15.3668 0.42161 -3.5" />
                            <Vertex pos="15.3668 2.42161 -3.5" />
                            <Vertex pos="15.3668 2.42161 2.5" />
                            <Vertex pos="17.3668 2.42161 2.5" />
                            <Vertex pos="17.3668 2.42161 -3.5" />
                        </Vertices>
                        <Face id="384" plane="-0 -1 -0 0.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="385" plane="-1 0 0 15.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="386" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 5" />
                        </Face>
                        <Face id="387" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 7" />
                        </Face>
                        <Face id="388" plane="1 -0 0 -17.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 6 7" />
                        </Face>
                        <Face id="389" plane="0 1 0 -2.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="940" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="15.3668 4.42161 -3.5" />
                            <Vertex pos="17.3668 4.42161 -3.5" />
                            <Vertex pos="17.3668 4.42161 2.5" />
                            <Vertex pos="15.3668 4.42161 2.5" />
                            <Vertex pos="15.3668 2.42161 -3.5" />
                            <Vertex pos="15.3668 2.42161 2.5" />
                            <Vertex pos="17.3668 2.42161 2.5" />
                            <Vertex pos="17.3668 2.42161 -3.5" />
                        </Vertices>
                        <Face id="384" plane="0 1 -0 -4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="385" plane="-1 0 0 15.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="386" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 5" />
                        </Face>
                        <Face id="387" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 7" />
                        </Face>
                        <Face id="388" plane="1 0 0 -17.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="389" plane="0 -1 0 2.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="941" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="403" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="23.3668 0.42161 2.5" />
                            <Vertex pos="25.3668 0.42161 2.5" />
                            <Vertex pos="25.3668 0.42161 -3.5" />
                            <Vertex pos="23.3668 0.42161 -3.5" />
                            <Vertex pos="23.3668 2.42161 -3.5" />
                            <Vertex pos="23.3668 2.42161 2.5" />
                            <Vertex pos="25.3668 2.42161 2.5" />
                            <Vertex pos="25.3668 2.42161 -3.5" />
                        </Vertices>
                        <Face id="396" plane="-0 -1 -0 0.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="397" plane="-1 0 0 23.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="398" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 5" />
                        </Face>
                        <Face id="399" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 7" />
                        </Face>
                        <Face id="400" plane="1 -0 0 -25.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 6 7" />
                        </Face>
                        <Face id="401" plane="0 1 0 -2.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="942" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="403" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="23.3668 4.42161 -3.5" />
                            <Vertex pos="25.3668 4.42161 -3.5" />
                            <Vertex pos="25.3668 4.42161 2.5" />
                            <Vertex pos="23.3668 4.42161 2.5" />
                            <Vertex pos="23.3668 2.42161 -3.5" />
                            <Vertex pos="23.3668 2.42161 2.5" />
                            <Vertex pos="25.3668 2.42161 2.5" />
                            <Vertex pos="25.3668 2.42161 -3.5" />
                        </Vertices>
                        <Face id="396" plane="0 1 -0 -4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="397" plane="-1 0 0 23.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="398" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 5" />
                        </Face>
                        <Face id="399" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 7" />
                        </Face>
                        <Face id="400" plane="1 0 0 -25.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="401" plane="0 -1 0 2.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="944" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="433" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 4.42161 -3.5" />
                            <Vertex pos="33.3668 4.42161 -3.5" />
                            <Vertex pos="33.3668 4.42161 2.5" />
                            <Vertex pos="31.3668 4.42161 2.5" />
                            <Vertex pos="33.3668 2.42161 2.5" />
                            <Vertex pos="33.3668 2.42161 -3.5" />
                            <Vertex pos="31.3668 2.42161 2.5" />
                            <Vertex pos="31.3668 2.42161 -3.5" />
                        </Vertices>
                        <Face id="426" plane="0 1 -0 -4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="427" plane="1 0 0 -33.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="428" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="429" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="430" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="431" plane="0 -1 0 2.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="952" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-26.6332 26.4216 -3.5" />
                            <Vertex pos="-26.6332 28.4216 -3.5" />
                            <Vertex pos="-26.6332 28.4216 2.5" />
                            <Vertex pos="-26.6332 26.4216 2.5" />
                            <Vertex pos="-22.6332 28.4216 -3.5" />
                            <Vertex pos="-22.6332 28.4216 2.5" />
                            <Vertex pos="-22.6332 26.4216 2.5" />
                            <Vertex pos="-22.6332 26.4216 -3.5" />
                        </Vertices>
                        <Face id="456" plane="-1 0 0 -26.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="458" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="459" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="460" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="461" plane="1 -0 0 22.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="963" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="325" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.13315 -25.5784 -3.5" />
                            <Vertex pos="-7.13315 -27.5784 -3.5" />
                            <Vertex pos="-7.13315 -27.5784 2.5" />
                            <Vertex pos="-7.13315 -25.5784 2.5" />
                            <Vertex pos="-9.13315 -27.5784 2.5" />
                            <Vertex pos="-9.13315 -27.5784 -3.5" />
                            <Vertex pos="-9.13315 -25.5784 2.5" />
                            <Vertex pos="-9.13315 -25.5784 -3.5" />
                        </Vertices>
                        <Face id="318" plane="1 0 0 7.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="319" plane="-0 -1 -0 -27.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="320" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="321" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="322" plane="0 1 0 25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="323" plane="-1 -0 -0 -9.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="982" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="475" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16.6332 26.4216 -3.5" />
                            <Vertex pos="-16.6332 26.4216 2.5" />
                            <Vertex pos="-16.6332 28.4216 2.5" />
                            <Vertex pos="-16.6332 28.4216 -3.5" />
                            <Vertex pos="-18.6332 28.4216 -3.5" />
                            <Vertex pos="-18.6332 28.4216 2.5" />
                            <Vertex pos="-18.6332 26.4216 2.5" />
                            <Vertex pos="-18.6332 26.4216 -3.5" />
                        </Vertices>
                        <Face id="468" plane="1 -0 0 16.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="469" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="470" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="471" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="472" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="473" plane="-1 0 0 -18.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="983" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="715" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-11.1332 4.42161 -3.5" />
                            <Vertex pos="-11.1332 8.42161 -3.5" />
                            <Vertex pos="-11.1332 8.42161 2.5" />
                            <Vertex pos="-11.1332 4.42161 2.5" />
                            <Vertex pos="-9.13315 8.42161 -3.5" />
                            <Vertex pos="-9.13315 8.42161 2.5" />
                            <Vertex pos="-9.13315 4.42161 2.5" />
                            <Vertex pos="-9.13315 4.42161 -3.5" />
                        </Vertices>
                        <Face id="708" plane="-1 0 0 -11.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="709" plane="0 1 -0 -8.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="710" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="711" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="712" plane="0 -1 0 4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="713" plane="1 -0 0 9.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="987" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="703" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.13315 0.42161 -3.5" />
                            <Vertex pos="-9.13315 0.42161 2.5" />
                            <Vertex pos="-9.13315 2.42161 2.5" />
                            <Vertex pos="-9.13315 2.42161 -3.5" />
                            <Vertex pos="-11.1332 2.42161 -3.5" />
                            <Vertex pos="-11.1332 2.42161 2.5" />
                            <Vertex pos="-11.1332 0.42161 2.5" />
                            <Vertex pos="-11.1332 0.42161 -3.5" />
                        </Vertices>
                        <Face id="696" plane="1 -0 0 9.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="697" plane="0 1 -0 -2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="698" plane="-0 -1 -0 0.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="699" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="700" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="701" plane="-1 0 0 -11.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="988" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="703" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-13.1332 0.42161 -3.5" />
                            <Vertex pos="-13.1332 2.42161 -3.5" />
                            <Vertex pos="-13.1332 2.42161 2.5" />
                            <Vertex pos="-13.1332 0.42161 2.5" />
                            <Vertex pos="-11.1332 2.42161 -3.5" />
                            <Vertex pos="-11.1332 2.42161 2.5" />
                            <Vertex pos="-11.1332 0.42161 2.5" />
                            <Vertex pos="-11.1332 0.42161 -3.5" />
                        </Vertices>
                        <Face id="696" plane="-1 0 0 -13.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="697" plane="0 1 -0 -2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="698" plane="-0 -1 -0 0.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="699" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="700" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="701" plane="1 -0 0 11.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="989" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="805" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.6332 5.42161 -3.5" />
                            <Vertex pos="-7.6332 5.42161 2.5" />
                            <Vertex pos="-7.6332 7.42161 2.5" />
                            <Vertex pos="-7.6332 7.42161 -3.5" />
                            <Vertex pos="-9.6332 7.42161 -3.5" />
                            <Vertex pos="-9.6332 7.42161 2.5" />
                            <Vertex pos="-9.6332 5.42161 2.5" />
                            <Vertex pos="-9.6332 5.42161 -3.5" />
                        </Vertices>
                        <Face id="798" plane="1 -0 0 7.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="799" plane="0 1 -0 -7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="800" plane="-0 -1 -0 5.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="801" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="802" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="803" plane="-1 0 0 -9.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="991" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-11.1332 -25.5784 -3.5" />
                            <Vertex pos="-11.1332 -27.5784 -3.5" />
                            <Vertex pos="-11.1332 -27.5784 2.5" />
                            <Vertex pos="-11.1332 -25.5784 2.5" />
                            <Vertex pos="-13.1332 -27.5784 2.5" />
                            <Vertex pos="-13.1332 -27.5784 -3.5" />
                            <Vertex pos="-13.1332 -25.5784 2.5" />
                            <Vertex pos="-13.1332 -25.5784 -3.5" />
                        </Vertices>
                        <Face id="330" plane="1 0 0 11.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="331" plane="-0 -1 -0 -27.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="332" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="333" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="334" plane="-0 1 0 25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="335" plane="-1 -0 -0 -13.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="992" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-15.1332 -25.5784 -3.5" />
                            <Vertex pos="-15.1332 -25.5784 2.5" />
                            <Vertex pos="-15.1332 -27.5784 2.5" />
                            <Vertex pos="-15.1332 -27.5784 -3.5" />
                            <Vertex pos="-13.1332 -27.5784 2.5" />
                            <Vertex pos="-13.1332 -27.5784 -3.5" />
                            <Vertex pos="-13.1332 -25.5784 2.5" />
                            <Vertex pos="-13.1332 -25.5784 -3.5" />
                        </Vertices>
                        <Face id="330" plane="-1 -0 -0 -15.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="331" plane="-0 -1 -0 -27.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="332" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="333" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="334" plane="-0 1 0 25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="335" plane="1 0 0 13.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="997" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="481" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-18.6332 26.4216 -3.5" />
                            <Vertex pos="-18.6332 26.4216 2.5" />
                            <Vertex pos="-18.6332 28.4216 2.5" />
                            <Vertex pos="-18.6332 28.4216 -3.5" />
                            <Vertex pos="-20.6332 28.4216 -3.5" />
                            <Vertex pos="-20.6332 28.4216 2.5" />
                            <Vertex pos="-20.6332 26.4216 2.5" />
                            <Vertex pos="-20.6332 26.4216 -3.5" />
                        </Vertices>
                        <Face id="474" plane="1 -0 0 18.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="475" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="476" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="477" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="478" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="479" plane="-1 0 0 -20.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="998" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="481" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-22.6332 26.4216 -3.5" />
                            <Vertex pos="-22.6332 28.4216 -3.5" />
                            <Vertex pos="-22.6332 28.4216 2.5" />
                            <Vertex pos="-22.6332 26.4216 2.5" />
                            <Vertex pos="-20.6332 28.4216 -3.5" />
                            <Vertex pos="-20.6332 28.4216 2.5" />
                            <Vertex pos="-20.6332 26.4216 2.5" />
                            <Vertex pos="-20.6332 26.4216 -3.5" />
                        </Vertices>
                        <Face id="474" plane="-1 0 0 -22.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="475" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="476" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="477" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="478" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="479" plane="1 -0 0 20.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1011" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="457" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 14.4216 -3.5" />
                            <Vertex pos="31.3668 14.4216 2.5" />
                            <Vertex pos="33.3796 14.4216 2.5" />
                            <Vertex pos="33.3796 14.4216 -3.5" />
                            <Vertex pos="33.3796 16.4216 -3.5" />
                            <Vertex pos="33.3796 16.4216 2.5" />
                            <Vertex pos="31.3668 16.4216 2.5" />
                            <Vertex pos="31.3668 16.4216 -3.5" />
                        </Vertices>
                        <Face id="450" plane="0 -1 0 14.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="451" plane="1 0 0 -33.3796" album="MyAlbum" material="images (3)" texgens="0.0132002 0.999913 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="452" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="453" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="454" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="455" plane="0 1 -0 -16.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1013" owner="0" type="0" pos="-17.8255 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -17.8255 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="343" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10.1332 3.42164 -3.5" />
                            <Vertex pos="-14.1332 3.42164 -3.5" />
                            <Vertex pos="-14.1332 3.42164 2.5" />
                            <Vertex pos="-10.1332 3.42164 2.5" />
                            <Vertex pos="-14.1332 5.42164 -3.5" />
                            <Vertex pos="-14.1332 5.42164 2.5" />
                            <Vertex pos="-10.1332 5.42164 2.5" />
                            <Vertex pos="-10.1332 5.42164 -3.5" />
                        </Vertices>
                        <Face id="336" plane="0 -1 0 3.42164" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="337" plane="-1 0 0 -14.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="338" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="339" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="340" plane="1 0 0 10.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="341" plane="0 1 0 -5.42164" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1017" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="817" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.6332 9.42161 -3.5" />
                            <Vertex pos="-11.6332 9.42161 -3.5" />
                            <Vertex pos="-11.6332 9.42161 2.5" />
                            <Vertex pos="-9.6332 9.42161 2.5" />
                            <Vertex pos="-11.6332 11.4216 -3.5" />
                            <Vertex pos="-11.6332 11.4216 2.5" />
                            <Vertex pos="-9.6332 11.4216 2.5" />
                            <Vertex pos="-9.6332 11.4216 -3.5" />
                        </Vertices>
                        <Face id="810" plane="0 -1 0 9.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="811" plane="-1 0 0 -11.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="812" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="813" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="814" plane="1 0 0 9.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="815" plane="0 1 0 -11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1027" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="805" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-13.6332 1.42161 -3.5" />
                            <Vertex pos="-13.6332 1.42161 2.5" />
                            <Vertex pos="-11.6332 1.42161 2.5" />
                            <Vertex pos="-11.6332 1.42161 -3.5" />
                            <Vertex pos="-13.6332 5.42161 -3.5" />
                            <Vertex pos="-13.6332 5.42161 2.5" />
                            <Vertex pos="-11.6332 5.42161 2.5" />
                            <Vertex pos="-11.6332 5.42161 -3.5" />
                        </Vertices>
                        <Face id="798" plane="0 -1 0 1.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="799" plane="-1 0 0 -13.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="800" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 5 6 2" />
                        </Face>
                        <Face id="801" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 7 4" />
                        </Face>
                        <Face id="802" plane="1 -0 0 11.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="803" plane="0 1 0 -5.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1028" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="805" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-13.6332 7.42161 -3.5" />
                            <Vertex pos="-11.6332 7.42161 -3.5" />
                            <Vertex pos="-11.6332 7.42161 2.5" />
                            <Vertex pos="-13.6332 7.42161 2.5" />
                            <Vertex pos="-13.6332 5.42161 -3.5" />
                            <Vertex pos="-13.6332 5.42161 2.5" />
                            <Vertex pos="-11.6332 5.42161 2.5" />
                            <Vertex pos="-11.6332 5.42161 -3.5" />
                        </Vertices>
                        <Face id="798" plane="0 1 -0 -7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="799" plane="-1 0 0 -13.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="800" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="801" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 1 0 4" />
                        </Face>
                        <Face id="802" plane="1 0 0 11.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="803" plane="0 -1 0 5.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1029" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="457" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="33.3792 4.42161 -3.5" />
                            <Vertex pos="31.3668 4.42161 -3.5" />
                            <Vertex pos="31.3668 4.42161 2.5" />
                            <Vertex pos="33.3792 4.42161 2.5" />
                            <Vertex pos="33.3794 10.4216 -3.5" />
                            <Vertex pos="33.3794 10.4216 2.5" />
                            <Vertex pos="31.3668 10.4216 2.5" />
                            <Vertex pos="31.3668 10.4216 -3.5" />
                        </Vertices>
                        <Face id="450" plane="0 -1 0 4.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="451" plane="1 -3.30608e-005 0 -33.3791" album="MyAlbum" material="images (3)" texgens="0.0132002 0.999913 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="452" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="453" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 1 0 4" />
                        </Face>
                        <Face id="454" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="455" plane="0 1 -0 -10.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1031" owner="0" type="0" pos="-17.8255 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -17.8255 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="343" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-14.1332 -6.57836 -3.5" />
                            <Vertex pos="-14.1332 -6.57836 2.5" />
                            <Vertex pos="-12.1332 -6.57836 2.5" />
                            <Vertex pos="-12.1332 -6.57836 -3.5" />
                            <Vertex pos="-14.1332 -0.57836 -3.5" />
                            <Vertex pos="-14.1332 -0.57836 2.5" />
                            <Vertex pos="-12.1332 -0.57836 2.5" />
                            <Vertex pos="-12.1332 -0.57836 -3.5" />
                        </Vertices>
                        <Face id="336" plane="0 -1 0 -6.57836" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="337" plane="-1 0 0 -14.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="338" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 5 6 2" />
                        </Face>
                        <Face id="339" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 7 4" />
                        </Face>
                        <Face id="340" plane="1 -0 0 12.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="341" plane="0 1 0 0.57836" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1069" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="289" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.13315 9.42161 2.5" />
                            <Vertex pos="-3.13315 7.42161 2.5" />
                            <Vertex pos="-3.13315 7.42161 -3.5" />
                            <Vertex pos="-3.13315 9.42161 -3.5" />
                            <Vertex pos="-1.13315 9.42161 2.5" />
                            <Vertex pos="-1.13315 9.42161 -3.5" />
                            <Vertex pos="-1.13315 7.42161 2.5" />
                            <Vertex pos="-1.13315 7.42161 -3.5" />
                        </Vertices>
                        <Face id="282" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="283" plane="-0 1 0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="284" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="285" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 3 2 7" />
                        </Face>
                        <Face id="286" plane="0 -1 0 7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="287" plane="1 -0 0 1.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1081" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="493" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.63315 26.4216 -3.5" />
                            <Vertex pos="-2.63315 28.4216 -3.5" />
                            <Vertex pos="-2.63315 28.4216 2.5" />
                            <Vertex pos="-2.63315 26.4216 2.5" />
                            <Vertex pos="-0.63315 28.4216 -3.5" />
                            <Vertex pos="-0.63315 28.4216 2.5" />
                            <Vertex pos="-0.63315 26.4216 2.5" />
                            <Vertex pos="-0.63315 26.4216 -3.5" />
                        </Vertices>
                        <Face id="486" plane="-1 0 0 -2.63315" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="487" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="488" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="489" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="490" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="491" plane="1 -0 0 0.63315" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1095" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 16.4216 -3.5" />
                            <Vertex pos="31.3668 16.4216 2.5" />
                            <Vertex pos="33.3796 16.4216 2.5" />
                            <Vertex pos="33.3796 16.4216 -3.5" />
                            <Vertex pos="33.3796 18.4216 -3.5" />
                            <Vertex pos="33.3796 18.4216 2.5" />
                            <Vertex pos="31.3668 18.4216 2.5" />
                            <Vertex pos="31.3668 18.4216 -3.5" />
                        </Vertices>
                        <Face id="456" plane="0 -1 0 16.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="1 0 0 -33.3796" album="MyAlbum" material="images (3)" texgens="0.0132002 0.999913 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="458" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="459" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="460" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="461" plane="0 1 -0 -18.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1097" owner="0" type="0" pos="-17.8255 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -17.8255 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="349" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12.1332 5.42164 -3.5" />
                            <Vertex pos="-14.1332 5.42164 -3.5" />
                            <Vertex pos="-14.1332 5.42164 2.5" />
                            <Vertex pos="-12.1332 5.42164 2.5" />
                            <Vertex pos="-14.1332 7.42164 -3.5" />
                            <Vertex pos="-14.1332 7.42164 2.5" />
                            <Vertex pos="-12.1332 7.42164 2.5" />
                            <Vertex pos="-12.1332 7.42164 -3.5" />
                        </Vertices>
                        <Face id="342" plane="0 -1 0 5.42164" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="343" plane="-1 0 0 -14.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="344" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="345" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="346" plane="1 0 0 12.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="347" plane="0 1 0 -7.42164" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1101" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="823" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.6332 11.4216 -3.5" />
                            <Vertex pos="-11.6332 11.4216 -3.5" />
                            <Vertex pos="-11.6332 11.4216 2.5" />
                            <Vertex pos="-9.6332 11.4216 2.5" />
                            <Vertex pos="-11.6332 13.4216 -3.5" />
                            <Vertex pos="-11.6332 13.4216 2.5" />
                            <Vertex pos="-9.6332 13.4216 2.5" />
                            <Vertex pos="-9.6332 13.4216 -3.5" />
                        </Vertices>
                        <Face id="816" plane="0 -1 0 11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="817" plane="-1 0 0 -11.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="818" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="819" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="820" plane="1 0 0 9.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="821" plane="0 1 0 -13.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1140" owner="0" type="0" pos="6.87453 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 6.87453 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1681" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.13315 5.42161 -3.5" />
                            <Vertex pos="-3.13315 7.42161 -3.5" />
                            <Vertex pos="-3.13315 7.42161 2.5" />
                            <Vertex pos="-3.13315 5.42161 2.5" />
                            <Vertex pos="-3.12945 7.42161 -3.5" />
                            <Vertex pos="-3.12945 7.42161 2.5" />
                            <Vertex pos="-3.12203 5.42161 2.5" />
                            <Vertex pos="-3.12203 5.42161 -3.5" />
                        </Vertices>
                        <Face id="1674" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 288 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1675" plane="0 1 -0 -7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 288 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1676" plane="-0 -1 -0 5.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 288 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="1677" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 288 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="1678" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 288 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="1679" plane="0.999993 0.00371001 0 3.10189" album="MyAlbum" material="images (3)" texgens="-0.00370368 0.999993 0 288 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1165" owner="0" type="0" pos="9.47453 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 9.47453 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="709" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.86685 11.4216 -3.5" />
                            <Vertex pos="2.86685 11.4216 2.5" />
                            <Vertex pos="2.86685 13.4216 2.5" />
                            <Vertex pos="2.86685 13.4216 -3.5" />
                            <Vertex pos="-3.11677 13.4216 -3.5" />
                            <Vertex pos="-3.11677 13.4216 2.5" />
                            <Vertex pos="-3.11911 11.4216 2.5" />
                            <Vertex pos="-3.11911 11.4216 -3.5" />
                        </Vertices>
                        <Face id="702" plane="1 -0 0 -2.86685" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="703" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="704" plane="-0 -1 -0 11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="705" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="706" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="707" plane="-0.999999 0.00117004 0 -3.13247" album="MyAlbum" material="images (3)" texgens="0.00116959 0.999999 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1207" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="805" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.6332 5.42161 -3.5" />
                            <Vertex pos="-3.6332 5.42161 2.5" />
                            <Vertex pos="-3.6332 7.42161 2.5" />
                            <Vertex pos="-3.6332 7.42161 -3.5" />
                            <Vertex pos="-5.65244 7.42161 -3.5" />
                            <Vertex pos="-5.65244 7.42161 2.5" />
                            <Vertex pos="-5.65628 5.42161 2.5" />
                            <Vertex pos="-5.65628 5.42161 -3.5" />
                        </Vertices>
                        <Face id="798" plane="1 -0 0 3.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="799" plane="0 1 -0 -7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="800" plane="-0 -1 -0 5.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="801" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="802" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="803" plane="-0.999998 0.00191998 0 -5.66668" album="MyAlbum" material="images (3)" texgens="0.00192307 0.999998 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1208" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="805" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.6332 5.42161 -3.5" />
                            <Vertex pos="-7.6332 7.42161 -3.5" />
                            <Vertex pos="-7.6332 7.42161 2.5" />
                            <Vertex pos="-7.6332 5.42161 2.5" />
                            <Vertex pos="-5.65244 7.42161 -3.5" />
                            <Vertex pos="-5.65244 7.42161 2.5" />
                            <Vertex pos="-5.65628 5.42161 2.5" />
                            <Vertex pos="-5.65628 5.42161 -3.5" />
                        </Vertices>
                        <Face id="798" plane="-1 0 0 -7.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="799" plane="0 1 -0 -7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="800" plane="-0 -1 -0 5.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="801" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="802" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="803" plane="0.999998 -0.00191998 0 5.66668" album="MyAlbum" material="images (3)" texgens="0.00192307 0.999998 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1217" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.13315 -25.5784 -3.5" />
                            <Vertex pos="-9.13315 -27.5784 -3.5" />
                            <Vertex pos="-9.13315 -27.5784 2.5" />
                            <Vertex pos="-9.13315 -25.5784 2.5" />
                            <Vertex pos="-9.24469 -27.5784 2.5" />
                            <Vertex pos="-9.24469 -27.5784 -3.5" />
                            <Vertex pos="-9.24085 -25.5784 2.5" />
                            <Vertex pos="-9.24085 -25.5784 -3.5" />
                        </Vertices>
                        <Face id="330" plane="1 0 0 9.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="331" plane="-0 -1 -0 -27.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="332" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="333" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="334" plane="-0 1 0 25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="335" plane="-0.999998 0.00191974 0 -9.19173" album="MyAlbum" material="images (3)" texgens="0.00192307 0.999998 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1218" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-11.1332 -25.5784 -3.5" />
                            <Vertex pos="-11.1332 -25.5784 2.5" />
                            <Vertex pos="-11.1332 -27.5784 2.5" />
                            <Vertex pos="-11.1332 -27.5784 -3.5" />
                            <Vertex pos="-9.24469 -27.5784 2.5" />
                            <Vertex pos="-9.24469 -27.5784 -3.5" />
                            <Vertex pos="-9.24085 -25.5784 2.5" />
                            <Vertex pos="-9.24085 -25.5784 -3.5" />
                        </Vertices>
                        <Face id="330" plane="-1 -0 -0 -11.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="331" plane="-0 -1 -0 -27.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="332" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="333" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="334" plane="-0 1 0 25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="335" plane="0.999998 -0.00191974 0 9.19173" album="MyAlbum" material="images (3)" texgens="0.00192307 0.999998 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1223" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="721" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.13315 4.42161 2.5" />
                            <Vertex pos="-7.13315 6.42161 2.5" />
                            <Vertex pos="-7.13315 6.42161 -3.5" />
                            <Vertex pos="-7.13315 4.42161 -3.5" />
                            <Vertex pos="-7.16392 6.42161 -3.5" />
                            <Vertex pos="-7.16392 6.42161 2.5" />
                            <Vertex pos="-7.16777 4.42161 2.5" />
                            <Vertex pos="-7.16777 4.42161 -3.5" />
                        </Vertices>
                        <Face id="714" plane="1 0 0 7.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="715" plane="0 1 -0 -6.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="716" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="717" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="718" plane="0 -1 0 4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="719" plane="-0.999998 0.00192499 0 -7.17627" album="MyAlbum" material="images (3)" texgens="0.00192307 0.999998 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1224" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="721" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.13315 4.42161 -3.5" />
                            <Vertex pos="-9.13315 6.42161 -3.5" />
                            <Vertex pos="-9.13315 6.42161 2.5" />
                            <Vertex pos="-9.13315 4.42161 2.5" />
                            <Vertex pos="-7.16392 6.42161 -3.5" />
                            <Vertex pos="-7.16392 6.42161 2.5" />
                            <Vertex pos="-7.16777 4.42161 2.5" />
                            <Vertex pos="-7.16777 4.42161 -3.5" />
                        </Vertices>
                        <Face id="714" plane="-1 0 0 -9.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="715" plane="0 1 -0 -6.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="716" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="717" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="718" plane="0 -1 0 4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="719" plane="0.999998 -0.00192499 0 7.17627" album="MyAlbum" material="images (3)" texgens="0.00192307 0.999998 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1226" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="481" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16.6332 26.4216 -3.5" />
                            <Vertex pos="-16.6332 28.4216 -3.5" />
                            <Vertex pos="-16.6332 28.4216 2.5" />
                            <Vertex pos="-16.6332 26.4216 2.5" />
                            <Vertex pos="-16.6216 28.4216 -3.5" />
                            <Vertex pos="-16.6216 28.4216 2.5" />
                            <Vertex pos="-16.6255 26.4216 2.5" />
                            <Vertex pos="-16.6255 26.4216 -3.5" />
                        </Vertices>
                        <Face id="474" plane="-1 0 0 -16.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="475" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="476" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="477" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="478" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="479" plane="0.999998 -0.00195026 0 16.677" album="MyAlbum" material="images (3)" texgens="0.00192307 0.999998 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1456" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="469" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 28.4216 -3.5" />
                            <Vertex pos="33.38 28.4216 -3.5" />
                            <Vertex pos="33.38 28.4216 2.5" />
                            <Vertex pos="31.3668 28.4216 2.5" />
                            <Vertex pos="33.38 26.4216 -3.5" />
                            <Vertex pos="33.38 26.4216 2.5" />
                            <Vertex pos="31.3668 26.4216 2.5" />
                            <Vertex pos="31.3668 26.4216 -3.5" />
                        </Vertices>
                        <Face id="462" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="463" plane="1 0 0 -33.38" album="MyAlbum" material="images (3)" texgens="0.0132002 0.999913 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="464" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="465" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 7 4" />
                        </Face>
                        <Face id="466" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="467" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1460" owner="0" type="0" pos="-17.8255 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -17.8255 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="355" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12.1332 7.42164 -3.5" />
                            <Vertex pos="-14.1332 7.42164 -3.5" />
                            <Vertex pos="-14.1332 7.42164 2.5" />
                            <Vertex pos="-12.1332 7.42164 2.5" />
                            <Vertex pos="-14.1332 9.42164 -3.5" />
                            <Vertex pos="-14.1332 9.42164 2.5" />
                            <Vertex pos="-12.1332 9.42164 2.5" />
                            <Vertex pos="-12.1332 9.42164 -3.5" />
                        </Vertices>
                        <Face id="348" plane="0 -1 0 7.42164" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="349" plane="-1 0 0 -14.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="350" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="351" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="352" plane="1 0 0 12.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="353" plane="0 1 0 -9.42164" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1464" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="829" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.6332 13.4216 -3.5" />
                            <Vertex pos="-11.6332 13.4216 -3.5" />
                            <Vertex pos="-11.6332 13.4216 2.5" />
                            <Vertex pos="-9.6332 13.4216 2.5" />
                            <Vertex pos="-11.6332 15.4216 -3.5" />
                            <Vertex pos="-11.6332 15.4216 2.5" />
                            <Vertex pos="-9.6332 15.4216 2.5" />
                            <Vertex pos="-9.6332 15.4216 -3.5" />
                        </Vertices>
                        <Face id="822" plane="0 -1 0 13.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="823" plane="-1 0 0 -11.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="824" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="825" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="826" plane="1 0 0 9.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="827" plane="0 1 0 -15.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1468" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="475" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 18.4216 -3.5" />
                            <Vertex pos="31.3668 18.4216 2.5" />
                            <Vertex pos="33.3796 18.4216 2.5" />
                            <Vertex pos="33.3796 18.4216 -3.5" />
                            <Vertex pos="33.3798 20.4216 -3.5" />
                            <Vertex pos="33.3798 20.4216 2.5" />
                            <Vertex pos="31.3668 20.4216 2.5" />
                            <Vertex pos="31.3668 20.4216 -3.5" />
                        </Vertices>
                        <Face id="468" plane="0 -1 0 18.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="469" plane="1 -9.91821e-005 0 -33.3778" album="MyAlbum" material="images (3)" texgens="0.0132002 0.999913 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="470" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="471" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="472" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="473" plane="0 1 -0 -20.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1469" owner="0" type="0" pos="-2.87547 15.6894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -2.87547 0 1.3 0 15.6894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="427" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.36685 14.4216 -3.5" />
                            <Vertex pos="2.36685 14.4216 -3.5" />
                            <Vertex pos="2.36685 14.4216 2.5" />
                            <Vertex pos="0.36685 14.4216 2.5" />
                            <Vertex pos="2.36685 12.4216 2.5" />
                            <Vertex pos="2.36685 12.4216 -3.5" />
                            <Vertex pos="0.36685 12.4216 2.5" />
                            <Vertex pos="0.36685 12.4216 -3.5" />
                        </Vertices>
                        <Face id="420" plane="0 1 -0 -14.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="421" plane="1 0 0 -2.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="422" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="423" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="424" plane="-1 0 0 0.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="425" plane="0 -1 0 12.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1470" owner="0" type="0" pos="-2.87547 15.6894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -2.87547 0 1.3 0 15.6894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="427" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.36685 10.4216 2.5" />
                            <Vertex pos="2.36685 10.4216 2.5" />
                            <Vertex pos="2.36685 10.4216 -3.5" />
                            <Vertex pos="0.36685 10.4216 -3.5" />
                            <Vertex pos="2.36685 12.4216 2.5" />
                            <Vertex pos="2.36685 12.4216 -3.5" />
                            <Vertex pos="0.36685 12.4216 2.5" />
                            <Vertex pos="0.36685 12.4216 -3.5" />
                        </Vertices>
                        <Face id="420" plane="-0 -1 -0 10.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="421" plane="1 -0 0 -2.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="422" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="423" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="424" plane="-1 0 0 0.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="425" plane="0 1 -0 -12.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1471" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="512" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-10.6296 26.4216 -3.5" />
                            <Vertex pos="-8.63315 26.4216 -3.5" />
                            <Vertex pos="-8.63315 26.4216 2.5" />
                            <Vertex pos="-10.6296 26.4216 2.5" />
                            <Vertex pos="-8.63315 22.4216 2.5" />
                            <Vertex pos="-8.63315 22.4216 -3.5" />
                            <Vertex pos="-10.6201 22.4216 2.5" />
                            <Vertex pos="-10.6201 22.4216 -3.5" />
                        </Vertices>
                        <Face id="505" plane="0 1 -0 -26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="506" plane="1 0 0 8.63315" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="507" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="508" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 5 1" />
                        </Face>
                        <Face id="509" plane="-0.999997 -0.00237488 -0 -10.5668" album="MyAlbum" material="images (3)" texgens="-0.0178543 0.999841 0 16 0 0 1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="510" plane="0 -1 0 22.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1473" owner="0" type="0" pos="-17.8255 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -17.8255 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="361" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-14.1332 13.4216 -3.5" />
                            <Vertex pos="-12.1332 13.4216 -3.5" />
                            <Vertex pos="-12.1332 13.4216 2.5" />
                            <Vertex pos="-14.1332 13.4216 2.5" />
                            <Vertex pos="-14.1332 11.4216 -3.5" />
                            <Vertex pos="-14.1332 11.4216 2.5" />
                            <Vertex pos="-12.1332 11.4216 2.5" />
                            <Vertex pos="-12.1332 11.4216 -3.5" />
                        </Vertices>
                        <Face id="354" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="355" plane="-1 0 0 -14.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="356" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="357" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 1 0 4" />
                        </Face>
                        <Face id="358" plane="1 0 0 12.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="359" plane="0 -1 0 11.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1474" owner="0" type="0" pos="-17.8255 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -17.8255 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="361" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12.1332 9.42164 -3.5" />
                            <Vertex pos="-14.1332 9.42164 -3.5" />
                            <Vertex pos="-14.1332 9.42164 2.5" />
                            <Vertex pos="-12.1332 9.42164 2.5" />
                            <Vertex pos="-14.1332 11.4216 -3.5" />
                            <Vertex pos="-14.1332 11.4216 2.5" />
                            <Vertex pos="-12.1332 11.4216 2.5" />
                            <Vertex pos="-12.1332 11.4216 -3.5" />
                        </Vertices>
                        <Face id="354" plane="0 -1 0 9.42164" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="355" plane="-1 0 0 -14.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="356" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="357" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="358" plane="1 0 0 12.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="359" plane="0 1 0 -11.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1477" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="835" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-11.6332 19.4216 -3.5" />
                            <Vertex pos="-9.6332 19.4216 -3.5" />
                            <Vertex pos="-9.6332 19.4216 2.5" />
                            <Vertex pos="-11.6332 19.4216 2.5" />
                            <Vertex pos="-11.6332 17.4216 -3.5" />
                            <Vertex pos="-11.6332 17.4216 2.5" />
                            <Vertex pos="-9.6332 17.4216 2.5" />
                            <Vertex pos="-9.6332 17.4216 -3.5" />
                        </Vertices>
                        <Face id="828" plane="0 1 -0 -19.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="829" plane="-1 0 0 -11.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="830" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 5" />
                        </Face>
                        <Face id="831" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 1 0 4" />
                        </Face>
                        <Face id="832" plane="1 0 0 9.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="833" plane="0 -1 0 17.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1478" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="835" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.6332 15.4216 -3.5" />
                            <Vertex pos="-11.6332 15.4216 -3.5" />
                            <Vertex pos="-11.6332 15.4216 2.5" />
                            <Vertex pos="-9.6332 15.4216 2.5" />
                            <Vertex pos="-11.6332 17.4216 -3.5" />
                            <Vertex pos="-11.6332 17.4216 2.5" />
                            <Vertex pos="-9.6332 17.4216 2.5" />
                            <Vertex pos="-9.6332 17.4216 -3.5" />
                        </Vertices>
                        <Face id="828" plane="0 -1 0 15.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="829" plane="-1 0 0 -11.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="830" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="831" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="832" plane="1 0 0 9.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="833" plane="0 1 0 -17.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1479" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="481" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 26.4216 -3.5" />
                            <Vertex pos="33.38 26.4216 -3.5" />
                            <Vertex pos="33.38 26.4216 2.5" />
                            <Vertex pos="31.3668 26.4216 2.5" />
                            <Vertex pos="33.3798 22.4216 -3.5" />
                            <Vertex pos="33.3798 22.4216 2.5" />
                            <Vertex pos="31.3668 22.4216 2.5" />
                            <Vertex pos="31.3668 22.4216 -3.5" />
                        </Vertices>
                        <Face id="474" plane="0 1 -0 -26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="475" plane="1 -5.05447e-005 0 -33.3787" album="MyAlbum" material="images (3)" texgens="0.0132002 0.999913 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="476" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="477" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="478" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="479" plane="0 -1 0 22.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1480" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="481" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 20.4216 -3.5" />
                            <Vertex pos="31.3668 20.4216 2.5" />
                            <Vertex pos="33.3798 20.4216 2.5" />
                            <Vertex pos="33.3798 20.4216 -3.5" />
                            <Vertex pos="33.3798 22.4216 -3.5" />
                            <Vertex pos="33.3798 22.4216 2.5" />
                            <Vertex pos="31.3668 22.4216 2.5" />
                            <Vertex pos="31.3668 22.4216 -3.5" />
                        </Vertices>
                        <Face id="474" plane="0 -1 0 20.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="475" plane="1 0 0 -33.3798" album="MyAlbum" material="images (3)" texgens="0.0132002 0.999913 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="476" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="477" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="478" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="479" plane="0 1 -0 -22.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1484" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="499" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16.6332 26.4216 -3.5" />
                            <Vertex pos="-16.6332 28.4216 -3.5" />
                            <Vertex pos="-16.6332 28.4216 2.5" />
                            <Vertex pos="-16.6332 26.4216 2.5" />
                            <Vertex pos="-12.6332 28.4216 -3.5" />
                            <Vertex pos="-12.6332 28.4216 2.5" />
                            <Vertex pos="-12.6332 26.4216 2.5" />
                            <Vertex pos="-12.6332 26.4216 -3.5" />
                        </Vertices>
                        <Face id="492" plane="-1 0 0 -16.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="493" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="494" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="495" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="496" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="497" plane="1 -0 0 12.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1488" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="524" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16.6332 22.4216 -3.5" />
                            <Vertex pos="-16.6332 22.4216 2.5" />
                            <Vertex pos="-16.6332 20.4216 2.5" />
                            <Vertex pos="-16.6332 20.4216 -3.5" />
                            <Vertex pos="-12.6332 20.4216 -3.5" />
                            <Vertex pos="-12.6332 20.4216 2.5" />
                            <Vertex pos="-12.6332 22.4216 2.5" />
                            <Vertex pos="-12.6332 22.4216 -3.5" />
                        </Vertices>
                        <Face id="517" plane="-1 -0 -0 -16.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="518" plane="0 -1 0 20.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="519" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="520" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="521" plane="0 1 -0 -22.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="522" plane="1 0 0 12.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1495" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="524" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-18.6201 22.4216 -3.5" />
                            <Vertex pos="-16.6332 22.4216 -3.5" />
                            <Vertex pos="-16.6332 22.4216 2.5" />
                            <Vertex pos="-18.6201 22.4216 2.5" />
                            <Vertex pos="-18.6166 16.4216 2.5" />
                            <Vertex pos="-18.6166 16.4216 -3.5" />
                            <Vertex pos="-16.6332 16.4216 2.5" />
                            <Vertex pos="-16.6332 16.4216 -3.5" />
                        </Vertices>
                        <Face id="517" plane="0 1 -0 -22.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="518" plane="-1 -0.000583331 -0 -18.607" album="MyAlbum" material="images (3)" texgens="-0.0178543 0.999841 0 16 0 0 1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="519" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="520" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="521" plane="1 0 0 16.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="522" plane="0 -1 0 16.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1496" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="524" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-16.6332 14.4216 -3.5" />
                            <Vertex pos="-18.6154 14.4216 -3.5" />
                            <Vertex pos="-18.6154 14.4216 2.5" />
                            <Vertex pos="-16.6332 14.4216 2.5" />
                            <Vertex pos="-18.6166 16.4216 2.5" />
                            <Vertex pos="-18.6166 16.4216 -3.5" />
                            <Vertex pos="-16.6332 16.4216 2.5" />
                            <Vertex pos="-16.6332 16.4216 -3.5" />
                        </Vertices>
                        <Face id="517" plane="0 -1 0 14.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="518" plane="-1 -0.000599861 -0 -18.6067" album="MyAlbum" material="images (3)" texgens="-0.0178543 0.999841 0 16 0 0 1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="519" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="520" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="521" plane="1 0 0 16.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="522" plane="0 1 0 -16.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1497" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="853" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.6332 13.4216 -3.5" />
                            <Vertex pos="-1.6332 13.4216 -3.5" />
                            <Vertex pos="-1.6332 13.4216 2.5" />
                            <Vertex pos="-3.6332 13.4216 2.5" />
                            <Vertex pos="-3.6332 11.4216 -3.5" />
                            <Vertex pos="-3.6332 11.4216 2.5" />
                            <Vertex pos="-1.6332 11.4216 2.5" />
                            <Vertex pos="-1.6332 11.4216 -3.5" />
                        </Vertices>
                        <Face id="846" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="847" plane="-1 0 0 -3.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="848" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="849" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 7" />
                        </Face>
                        <Face id="850" plane="1 0 0 1.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="851" plane="0 -1 0 11.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1498" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="853" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.6332 9.42161 2.5" />
                            <Vertex pos="-1.6332 9.42161 2.5" />
                            <Vertex pos="-1.6332 9.42161 -3.5" />
                            <Vertex pos="-3.6332 9.42161 -3.5" />
                            <Vertex pos="-3.6332 11.4216 -3.5" />
                            <Vertex pos="-3.6332 11.4216 2.5" />
                            <Vertex pos="-1.6332 11.4216 2.5" />
                            <Vertex pos="-1.6332 11.4216 -3.5" />
                        </Vertices>
                        <Face id="846" plane="-0 -1 -0 9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="847" plane="-1 0 0 -3.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="848" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 5 6" />
                        </Face>
                        <Face id="849" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 7" />
                        </Face>
                        <Face id="850" plane="1 -0 0 1.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 6 7" />
                        </Face>
                        <Face id="851" plane="0 1 0 -11.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1501" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="530" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8.63315 20.4216 -3.5" />
                            <Vertex pos="-8.63315 20.4216 2.5" />
                            <Vertex pos="-8.63315 22.4216 2.5" />
                            <Vertex pos="-8.63315 22.4216 -3.5" />
                            <Vertex pos="-10.6332 20.4216 -3.5" />
                            <Vertex pos="-10.6332 20.4216 2.5" />
                            <Vertex pos="-10.6332 22.4216 2.5" />
                            <Vertex pos="-10.6332 22.4216 -3.5" />
                        </Vertices>
                        <Face id="523" plane="1 -0 0 8.63315" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="524" plane="0 -1 0 20.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="525" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 5 6" />
                        </Face>
                        <Face id="526" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 7" />
                        </Face>
                        <Face id="527" plane="0 1 -0 -22.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="528" plane="-1 -0 -0 -10.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1502" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="530" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12.6332 22.4216 -3.5" />
                            <Vertex pos="-12.6332 22.4216 2.5" />
                            <Vertex pos="-12.6332 20.4216 2.5" />
                            <Vertex pos="-12.6332 20.4216 -3.5" />
                            <Vertex pos="-10.6332 20.4216 -3.5" />
                            <Vertex pos="-10.6332 20.4216 2.5" />
                            <Vertex pos="-10.6332 22.4216 2.5" />
                            <Vertex pos="-10.6332 22.4216 -3.5" />
                        </Vertices>
                        <Face id="523" plane="-1 -0 -0 -12.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="524" plane="0 -1 0 20.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="525" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="526" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="527" plane="0 1 -0 -22.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="528" plane="1 0 0 10.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1503" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="511" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8.63315 26.4216 -3.5" />
                            <Vertex pos="-8.63315 26.4216 2.5" />
                            <Vertex pos="-8.63315 28.4216 2.5" />
                            <Vertex pos="-8.63315 28.4216 -3.5" />
                            <Vertex pos="-10.6332 28.4216 -3.5" />
                            <Vertex pos="-10.6332 28.4216 2.5" />
                            <Vertex pos="-10.6332 26.4216 2.5" />
                            <Vertex pos="-10.6332 26.4216 -3.5" />
                        </Vertices>
                        <Face id="504" plane="1 -0 0 8.63315" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="505" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="506" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="507" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="508" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="509" plane="-1 0 0 -10.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1506" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="866" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.6332 9.42161 -3.5" />
                            <Vertex pos="-1.6332 11.4216 -3.5" />
                            <Vertex pos="-1.6332 11.4216 2.5" />
                            <Vertex pos="-1.6332 9.42161 2.5" />
                            <Vertex pos="0.3668 9.42161 2.5" />
                            <Vertex pos="0.3668 9.42161 -3.5" />
                            <Vertex pos="0.3668 11.4216 2.5" />
                            <Vertex pos="0.3668 11.4216 -3.5" />
                        </Vertices>
                        <Face id="859" plane="-1 0 0 -1.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="860" plane="-0 -1 -0 9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="861" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="862" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 5 7" />
                        </Face>
                        <Face id="863" plane="-0 1 0 -11.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="864" plane="1 0 0 -0.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1512" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="878" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.6332 7.42161 2.5" />
                            <Vertex pos="-3.6332 3.42161 2.5" />
                            <Vertex pos="-3.6332 3.42161 -3.5" />
                            <Vertex pos="-3.6332 7.42161 -3.5" />
                            <Vertex pos="-1.6332 3.42161 2.5" />
                            <Vertex pos="-1.6332 3.42161 -3.5" />
                            <Vertex pos="-1.6332 7.42161 2.5" />
                            <Vertex pos="-1.6332 7.42161 -3.5" />
                        </Vertices>
                        <Face id="871" plane="-1 0 0 -3.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="872" plane="-0 -1 -0 3.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="873" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="874" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 7 3" />
                        </Face>
                        <Face id="875" plane="0 1 -0 -7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="876" plane="1 0 0 1.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1513" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="703" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-15.1332 4.42161 -3.5" />
                            <Vertex pos="-13.1332 4.42161 -3.5" />
                            <Vertex pos="-13.1332 4.42161 2.5" />
                            <Vertex pos="-15.1332 4.42161 2.5" />
                            <Vertex pos="-15.1332 2.42161 -3.5" />
                            <Vertex pos="-15.1332 2.42161 2.5" />
                            <Vertex pos="-13.1332 2.42161 2.5" />
                            <Vertex pos="-13.1332 2.42161 -3.5" />
                        </Vertices>
                        <Face id="696" plane="0 1 -0 -4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="697" plane="-1 0 0 -15.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="698" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="699" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 1 0 4" />
                        </Face>
                        <Face id="700" plane="1 0 0 13.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="701" plane="0 -1 0 2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1514" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="703" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-15.1332 0.42161 -3.5" />
                            <Vertex pos="-15.1332 0.42161 2.5" />
                            <Vertex pos="-13.1332 0.42161 2.5" />
                            <Vertex pos="-13.1332 0.42161 -3.5" />
                            <Vertex pos="-15.1332 2.42161 -3.5" />
                            <Vertex pos="-15.1332 2.42161 2.5" />
                            <Vertex pos="-13.1332 2.42161 2.5" />
                            <Vertex pos="-13.1332 2.42161 -3.5" />
                        </Vertices>
                        <Face id="696" plane="0 -1 0 0.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="697" plane="-1 0 0 -15.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="698" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 5 6 2" />
                        </Face>
                        <Face id="699" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 7 4" />
                        </Face>
                        <Face id="700" plane="1 -0 0 13.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="701" plane="0 1 0 -2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1515" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="721" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.13315 4.42161 -3.5" />
                            <Vertex pos="-7.13315 4.42161 2.5" />
                            <Vertex pos="-7.16777 4.42161 2.5" />
                            <Vertex pos="-7.16777 4.42161 -3.5" />
                            <Vertex pos="-7.13315 2.42161 2.5" />
                            <Vertex pos="-7.13315 2.42161 -3.5" />
                            <Vertex pos="-7.17161 2.42161 2.5" />
                            <Vertex pos="-7.17161 2.42161 -3.5" />
                        </Vertices>
                        <Face id="714" plane="0 1 0 -4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="715" plane="1 0 0 7.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="716" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 6 2" />
                        </Face>
                        <Face id="717" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 0 3 7" />
                        </Face>
                        <Face id="718" plane="-0.999998 0.00191998 0 -7.17625" album="MyAlbum" material="images (3)" texgens="0.00192307 0.999998 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="719" plane="0 -1 0 2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1517" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="721" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.16777 4.42161 2.5" />
                            <Vertex pos="-9.13315 4.42161 2.5" />
                            <Vertex pos="-9.13315 4.42161 -3.5" />
                            <Vertex pos="-7.16777 4.42161 -3.5" />
                            <Vertex pos="-9.13315 2.42161 -3.5" />
                            <Vertex pos="-9.13315 2.42161 2.5" />
                            <Vertex pos="-7.17161 2.42161 2.5" />
                            <Vertex pos="-7.17161 2.42161 -3.5" />
                        </Vertices>
                        <Face id="714" plane="-0 1 0 -4.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="715" plane="-1 0 0 -9.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="716" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="717" plane="-0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="718" plane="0.999998 -0.00191998 0 7.17625" album="MyAlbum" material="images (3)" texgens="0.00192307 0.999998 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="719" plane="0 -1 0 2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1518" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="721" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.13315 0.42161 2.5" />
                            <Vertex pos="-7.17546 0.42161 2.5" />
                            <Vertex pos="-7.17546 0.42161 -3.5" />
                            <Vertex pos="-9.13315 0.42161 -3.5" />
                            <Vertex pos="-9.13315 2.42161 -3.5" />
                            <Vertex pos="-9.13315 2.42161 2.5" />
                            <Vertex pos="-7.17161 2.42161 2.5" />
                            <Vertex pos="-7.17161 2.42161 -3.5" />
                        </Vertices>
                        <Face id="714" plane="-0 -1 -0 0.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="715" plane="-1 0 0 -9.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="716" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 5 6" />
                        </Face>
                        <Face id="717" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 7 4" />
                        </Face>
                        <Face id="718" plane="0.999998 -0.00192499 0 7.17626" album="MyAlbum" material="images (3)" texgens="0.00192307 0.999998 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="719" plane="0 1 0 -2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1521" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-26.6332 26.4216 -3.5" />
                            <Vertex pos="-26.6332 26.4216 2.5" />
                            <Vertex pos="-26.6332 28.4216 2.5" />
                            <Vertex pos="-26.6332 28.4216 -3.5" />
                            <Vertex pos="-30.6332 28.4216 -3.5" />
                            <Vertex pos="-30.6332 28.4216 2.5" />
                            <Vertex pos="-30.6332 26.4216 2.5" />
                            <Vertex pos="-30.6332 26.4216 -3.5" />
                        </Vertices>
                        <Face id="456" plane="1 -0 0 26.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="458" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="459" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="460" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="461" plane="-1 0 0 -30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1543" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="475" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-26.6332 -15.5784 -3.5" />
                            <Vertex pos="-26.6332 -15.5784 2.5" />
                            <Vertex pos="-32.6332 -15.5784 2.5" />
                            <Vertex pos="-32.6332 -15.5784 -3.5" />
                            <Vertex pos="-32.6332 -17.5784 -3.5" />
                            <Vertex pos="-32.6332 -17.5784 2.5" />
                            <Vertex pos="-26.6332 -17.5784 2.5" />
                            <Vertex pos="-26.6332 -17.5784 -3.5" />
                        </Vertices>
                        <Face id="468" plane="0 1 0 15.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="469" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="470" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="471" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="472" plane="1 0 0 26.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="473" plane="0 -1 0 -17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1547" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="481" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-26.6332 2.42161 -3.5" />
                            <Vertex pos="-26.6332 2.42161 2.5" />
                            <Vertex pos="-32.6332 2.42161 2.5" />
                            <Vertex pos="-32.6332 2.42161 -3.5" />
                            <Vertex pos="-32.6332 0.42161 -3.5" />
                            <Vertex pos="-32.6332 0.42161 2.5" />
                            <Vertex pos="-26.6332 0.42161 2.5" />
                            <Vertex pos="-26.6332 0.42161 -3.5" />
                        </Vertices>
                        <Face id="474" plane="0 1 0 -2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="475" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="476" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="477" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="478" plane="1 0 0 26.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="479" plane="0 -1 0 0.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1558" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="487" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 -15.5784 -3.5" />
                            <Vertex pos="-32.6332 -15.5784 -3.5" />
                            <Vertex pos="-32.6332 -15.5784 2.5" />
                            <Vertex pos="-30.6332 -15.5784 2.5" />
                            <Vertex pos="-32.6332 -13.5784 -3.5" />
                            <Vertex pos="-32.6332 -13.5784 2.5" />
                            <Vertex pos="-30.6332 -13.5784 2.5" />
                            <Vertex pos="-30.6332 -13.5784 -3.5" />
                        </Vertices>
                        <Face id="480" plane="0 -1 0 -15.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="481" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="482" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="483" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="484" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="485" plane="0 1 0 13.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1560" owner="0" type="0" pos="17.9245 -5.76063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.9245 0 1.3 0 -5.76063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1969" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.3668 -17.0784 -3.5" />
                            <Vertex pos="14.3668 -17.0784 2.5" />
                            <Vertex pos="16.3668 -17.0784 2.5" />
                            <Vertex pos="16.3668 -17.0784 -3.5" />
                            <Vertex pos="16.3668 -7.07839 2.5" />
                            <Vertex pos="16.3668 -7.07839 -3.5" />
                            <Vertex pos="14.3668 -7.07839 -3.5" />
                            <Vertex pos="14.3668 -7.07839 2.5" />
                        </Vertices>
                        <Face id="1962" plane="0 -1 0 -17.0784" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1963" plane="1 -0 0 -16.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="1964" plane="-1 0 0 14.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="1965" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="1966" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="1967" plane="0 1 0 7.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1561" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="271" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-21.1332 -8.57839 -3.5" />
                            <Vertex pos="-19.1332 -8.57839 -3.5" />
                            <Vertex pos="-19.1332 -8.57839 2.5" />
                            <Vertex pos="-21.1332 -8.57839 2.5" />
                            <Vertex pos="-21.1332 -10.5784 2.5" />
                            <Vertex pos="-21.1332 -10.5784 -3.5" />
                            <Vertex pos="-19.1332 -10.5784 2.5" />
                            <Vertex pos="-19.1332 -10.5784 -3.5" />
                        </Vertices>
                        <Face id="264" plane="0 1 -0 8.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="265" plane="-1 0 0 -21.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="266" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="267" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 1 0 5" />
                        </Face>
                        <Face id="268" plane="1 0 0 19.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="269" plane="0 -1 0 -10.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1564" owner="0" type="0" pos="-11.3255 0.089368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 0.089368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="997" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-19.1332 -11.5784 -3.5" />
                            <Vertex pos="-19.1332 -11.5784 2.5" />
                            <Vertex pos="-17.1332 -11.5784 2.5" />
                            <Vertex pos="-17.1332 -11.5784 -3.5" />
                            <Vertex pos="-19.1332 -9.57839 -3.5" />
                            <Vertex pos="-19.1332 -9.57839 2.5" />
                            <Vertex pos="-17.1332 -9.57839 2.5" />
                            <Vertex pos="-17.1332 -9.57839 -3.5" />
                        </Vertices>
                        <Face id="990" plane="0 -1 0 -11.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="991" plane="-1 0 0 -19.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="992" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 5 6 2" />
                        </Face>
                        <Face id="993" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 7 4" />
                        </Face>
                        <Face id="994" plane="1 -0 0 17.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="995" plane="0 1 0 9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1570" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="445" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 -13.5784 -3.5" />
                            <Vertex pos="31.3668 -13.5784 2.5" />
                            <Vertex pos="33.3668 -13.5784 2.5" />
                            <Vertex pos="33.3668 -13.5784 -3.5" />
                            <Vertex pos="33.3668 -11.5784 2.5" />
                            <Vertex pos="33.3668 -11.5784 -3.5" />
                            <Vertex pos="31.3668 -11.5784 2.5" />
                            <Vertex pos="31.3668 -11.5784 -3.5" />
                        </Vertices>
                        <Face id="438" plane="0 -1 0 -13.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="439" plane="1 0 0 -33.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="440" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="441" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="442" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="443" plane="0 1 -0 11.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1572" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="493" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 -13.5784 -3.5" />
                            <Vertex pos="-32.6332 -13.5784 -3.5" />
                            <Vertex pos="-32.6332 -13.5784 2.5" />
                            <Vertex pos="-30.6332 -13.5784 2.5" />
                            <Vertex pos="-32.6332 -11.5784 -3.5" />
                            <Vertex pos="-32.6332 -11.5784 2.5" />
                            <Vertex pos="-30.6332 -11.5784 2.5" />
                            <Vertex pos="-30.6332 -11.5784 -3.5" />
                        </Vertices>
                        <Face id="486" plane="0 -1 0 -13.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="487" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="488" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="489" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="490" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="491" plane="0 1 0 11.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1574" owner="0" type="0" pos="17.9245 -5.76063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.9245 0 1.3 0 -5.76063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1975" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.3668 -7.07839 2.5" />
                            <Vertex pos="16.3668 -7.07839 2.5" />
                            <Vertex pos="16.3668 -7.07839 -3.5" />
                            <Vertex pos="14.3668 -7.07839 -3.5" />
                            <Vertex pos="16.3668 -5.07839 2.5" />
                            <Vertex pos="16.3668 -5.07839 -3.5" />
                            <Vertex pos="14.3668 -5.07839 -3.5" />
                            <Vertex pos="14.3668 -5.07839 2.5" />
                        </Vertices>
                        <Face id="1968" plane="-0 -1 -0 -7.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1969" plane="1 0 0 -16.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1970" plane="-1 0 0 14.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="1971" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="1972" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="1973" plane="0 1 0 5.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1575" owner="0" type="0" pos="9.47453 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 9.47453 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="715" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5.13315 11.4216 -3.5" />
                            <Vertex pos="-5.13315 13.4216 -3.5" />
                            <Vertex pos="-5.13315 13.4216 2.5" />
                            <Vertex pos="-5.13315 11.4216 2.5" />
                            <Vertex pos="-3.13315 13.4216 -3.5" />
                            <Vertex pos="-3.13315 13.4216 2.5" />
                            <Vertex pos="-3.13315 11.4216 2.5" />
                            <Vertex pos="-3.13315 11.4216 -3.5" />
                        </Vertices>
                        <Face id="708" plane="-1 0 0 -5.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="709" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="710" plane="0 -1 0 11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="711" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="712" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="713" plane="1 -0 0 3.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1576" owner="0" type="0" pos="9.47453 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 9.47453 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="715" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.11911 11.4216 -3.5" />
                            <Vertex pos="-3.11911 11.4216 2.5" />
                            <Vertex pos="-3.11677 13.4216 2.5" />
                            <Vertex pos="-3.11677 13.4216 -3.5" />
                            <Vertex pos="-3.13315 13.4216 -3.5" />
                            <Vertex pos="-3.13315 13.4216 2.5" />
                            <Vertex pos="-3.13315 11.4216 2.5" />
                            <Vertex pos="-3.13315 11.4216 -3.5" />
                        </Vertices>
                        <Face id="708" plane="0.999999 -0.00117004 0 3.13247" album="MyAlbum" material="images (3)" texgens="0.00116959 0.999999 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="709" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="710" plane="-0 -1 -0 11.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="711" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="712" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 224 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="713" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 224 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1578" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="511" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.38556 26.4216 -3.5" />
                            <Vertex pos="3.38556 26.4216 2.5" />
                            <Vertex pos="3.3879 28.4216 2.5" />
                            <Vertex pos="3.3879 28.4216 -3.5" />
                            <Vertex pos="3.36685 28.4216 -3.5" />
                            <Vertex pos="3.36685 28.4216 2.5" />
                            <Vertex pos="3.36685 26.4216 2.5" />
                            <Vertex pos="3.36685 26.4216 -3.5" />
                        </Vertices>
                        <Face id="504" plane="0.999999 -0.00117004 0 -3.35464" album="MyAlbum" material="images (3)" texgens="0.00116959 0.999999 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="505" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="506" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="507" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="508" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="509" plane="-1 0 0 3.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1590" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="301" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.86685 7.42161 -3.5" />
                            <Vertex pos="8.86685 7.42161 2.5" />
                            <Vertex pos="8.86685 9.42161 2.5" />
                            <Vertex pos="8.86685 9.42161 -3.5" />
                            <Vertex pos="2.86685 9.42161 2.5" />
                            <Vertex pos="2.86685 9.42161 -3.5" />
                            <Vertex pos="2.86685 7.42161 2.5" />
                            <Vertex pos="2.86685 7.42161 -3.5" />
                        </Vertices>
                        <Face id="294" plane="1 -0 0 -8.86685" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="295" plane="-0 1 0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="296" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="297" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="298" plane="0 -1 0 7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="299" plane="-1 0 0 2.86685" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1607" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="481" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-32.6332 28.4216 -3.5" />
                            <Vertex pos="-30.6332 28.4216 -3.5" />
                            <Vertex pos="-30.6332 28.4216 2.5" />
                            <Vertex pos="-32.6332 28.4216 2.5" />
                            <Vertex pos="-32.6332 16.4216 -3.5" />
                            <Vertex pos="-32.6332 16.4216 2.5" />
                            <Vertex pos="-30.6332 16.4216 2.5" />
                            <Vertex pos="-30.6332 16.4216 -3.5" />
                        </Vertices>
                        <Face id="474" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="475" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="476" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 5" />
                        </Face>
                        <Face id="477" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 7" />
                        </Face>
                        <Face id="478" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="479" plane="0 -1 0 16.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1611" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="847" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.3668 13.4216 -3.5" />
                            <Vertex pos="10.3668 13.4216 -3.5" />
                            <Vertex pos="10.3668 13.4216 2.5" />
                            <Vertex pos="8.3668 13.4216 2.5" />
                            <Vertex pos="8.3668 11.4216 -3.5" />
                            <Vertex pos="8.3668 11.4216 2.5" />
                            <Vertex pos="10.3668 11.4216 2.5" />
                            <Vertex pos="10.3668 11.4216 -3.5" />
                        </Vertices>
                        <Face id="840" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="841" plane="-1 0 0 8.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="842" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="843" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 7" />
                        </Face>
                        <Face id="844" plane="1 0 0 -10.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="845" plane="0 -1 0 11.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1617" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="817" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-11.6332 5.42161 2.5" />
                            <Vertex pos="-9.6332 5.42161 2.5" />
                            <Vertex pos="-9.6332 5.42161 -3.5" />
                            <Vertex pos="-11.6332 5.42161 -3.5" />
                            <Vertex pos="-11.6332 7.42161 -3.5" />
                            <Vertex pos="-11.6332 7.42161 2.5" />
                            <Vertex pos="-9.6332 7.42161 2.5" />
                            <Vertex pos="-9.6332 7.42161 -3.5" />
                        </Vertices>
                        <Face id="810" plane="-0 -1 -0 5.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="811" plane="-1 0 0 -11.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="812" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 5" />
                        </Face>
                        <Face id="813" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 7 4" />
                        </Face>
                        <Face id="814" plane="1 -0 0 9.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 6 7" />
                        </Face>
                        <Face id="815" plane="0 1 0 -7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1618" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="817" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.6332 9.42161 -3.5" />
                            <Vertex pos="-9.6332 9.42161 2.5" />
                            <Vertex pos="-11.6332 9.42161 2.5" />
                            <Vertex pos="-11.6332 9.42161 -3.5" />
                            <Vertex pos="-11.6332 7.42161 -3.5" />
                            <Vertex pos="-11.6332 7.42161 2.5" />
                            <Vertex pos="-9.6332 7.42161 2.5" />
                            <Vertex pos="-9.6332 7.42161 -3.5" />
                        </Vertices>
                        <Face id="810" plane="0 1 0 -9.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="811" plane="-1 0 0 -11.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="812" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="813" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="814" plane="1 0 0 9.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="815" plane="0 -1 0 7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1619" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 10.4216 -3.5" />
                            <Vertex pos="31.3668 10.4216 2.5" />
                            <Vertex pos="33.3794 10.4216 2.5" />
                            <Vertex pos="33.3794 10.4216 -3.5" />
                            <Vertex pos="33.3794 12.4216 -3.5" />
                            <Vertex pos="33.3794 12.4216 2.5" />
                            <Vertex pos="31.3668 12.4216 2.5" />
                            <Vertex pos="31.3668 12.4216 -3.5" />
                        </Vertices>
                        <Face id="456" plane="0 -1 0 10.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="1 0 0 -33.3794" album="MyAlbum" material="images (3)" texgens="0.0132002 0.999913 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="458" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="459" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="460" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="461" plane="0 1 -0 -12.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1620" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 14.4216 -3.5" />
                            <Vertex pos="33.3796 14.4216 -3.5" />
                            <Vertex pos="33.3796 14.4216 2.5" />
                            <Vertex pos="31.3668 14.4216 2.5" />
                            <Vertex pos="33.3794 12.4216 -3.5" />
                            <Vertex pos="33.3794 12.4216 2.5" />
                            <Vertex pos="31.3668 12.4216 2.5" />
                            <Vertex pos="31.3668 12.4216 -3.5" />
                        </Vertices>
                        <Face id="456" plane="0 1 -0 -14.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="1 -0.000101089 0 -33.3781" album="MyAlbum" material="images (3)" texgens="0.0132002 0.999913 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="458" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="459" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="460" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="461" plane="0 -1 0 12.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1621" owner="0" type="0" pos="-17.8255 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -17.8255 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="349" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12.1332 -0.57836 -3.5" />
                            <Vertex pos="-14.1332 -0.57836 -3.5" />
                            <Vertex pos="-14.1332 -0.57836 2.5" />
                            <Vertex pos="-12.1332 -0.57836 2.5" />
                            <Vertex pos="-14.1332 1.42164 -3.5" />
                            <Vertex pos="-14.1332 1.42164 2.5" />
                            <Vertex pos="-12.1332 1.42164 2.5" />
                            <Vertex pos="-12.1332 1.42164 -3.5" />
                        </Vertices>
                        <Face id="342" plane="0 -1 0 -0.57836" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="343" plane="-1 0 0 -14.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="344" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="345" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="346" plane="1 0 0 12.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="347" plane="0 1 0 -1.42164" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1622" owner="0" type="0" pos="-17.8255 16.9894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -17.8255 0 1.3 0 16.9894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="349" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12.1332 3.42164 -3.5" />
                            <Vertex pos="-12.1332 3.42164 2.5" />
                            <Vertex pos="-14.1332 3.42164 2.5" />
                            <Vertex pos="-14.1332 3.42164 -3.5" />
                            <Vertex pos="-14.1332 1.42164 -3.5" />
                            <Vertex pos="-14.1332 1.42164 2.5" />
                            <Vertex pos="-12.1332 1.42164 2.5" />
                            <Vertex pos="-12.1332 1.42164 -3.5" />
                        </Vertices>
                        <Face id="342" plane="0 1 0 -3.42164" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="343" plane="-1 0 0 -14.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="344" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="345" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="346" plane="1 0 0 12.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="347" plane="0 -1 0 1.42164" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1625" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="878" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.3668 5.42161 -3.5" />
                            <Vertex pos="0.3668 5.42161 2.5" />
                            <Vertex pos="2.3668 5.42161 2.5" />
                            <Vertex pos="2.3668 5.42161 -3.5" />
                            <Vertex pos="2.3668 7.42161 -3.5" />
                            <Vertex pos="2.3668 7.42161 2.5" />
                            <Vertex pos="0.3668 7.42161 2.5" />
                            <Vertex pos="0.3668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="871" plane="0 -1 0 5.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="872" plane="1 0 0 -2.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="873" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="874" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="875" plane="-1 0 0 0.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="876" plane="0 1 -0 -7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1626" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="878" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.3668 11.4216 -3.5" />
                            <Vertex pos="2.3668 11.4216 2.5" />
                            <Vertex pos="0.3668 11.4216 2.5" />
                            <Vertex pos="0.3668 11.4216 -3.5" />
                            <Vertex pos="2.3668 7.42161 -3.5" />
                            <Vertex pos="2.3668 7.42161 2.5" />
                            <Vertex pos="0.3668 7.42161 2.5" />
                            <Vertex pos="0.3668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="871" plane="0 1 0 -11.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="872" plane="1 0 0 -2.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="873" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 5" />
                        </Face>
                        <Face id="874" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 7" />
                        </Face>
                        <Face id="875" plane="-1 -0 -0 0.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="876" plane="0 -1 0 7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1627" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="487" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 2.42161 -3.5" />
                            <Vertex pos="-32.6332 2.42161 -3.5" />
                            <Vertex pos="-32.6332 2.42161 2.5" />
                            <Vertex pos="-30.6332 2.42161 2.5" />
                            <Vertex pos="-32.6332 12.4216 -3.5" />
                            <Vertex pos="-32.6332 12.4216 2.5" />
                            <Vertex pos="-30.6332 12.4216 2.5" />
                            <Vertex pos="-30.6332 12.4216 -3.5" />
                        </Vertices>
                        <Face id="480" plane="0 -1 0 2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="481" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="482" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="483" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="484" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="485" plane="0 1 0 -12.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1628" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="487" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 16.4216 -3.5" />
                            <Vertex pos="-30.6332 16.4216 2.5" />
                            <Vertex pos="-32.6332 16.4216 2.5" />
                            <Vertex pos="-32.6332 16.4216 -3.5" />
                            <Vertex pos="-32.6332 12.4216 -3.5" />
                            <Vertex pos="-32.6332 12.4216 2.5" />
                            <Vertex pos="-30.6332 12.4216 2.5" />
                            <Vertex pos="-30.6332 12.4216 -3.5" />
                        </Vertices>
                        <Face id="480" plane="0 1 0 -16.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="481" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="482" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="483" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="484" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="485" plane="0 -1 0 12.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1630" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="871" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="12.3668 15.4216 -3.5" />
                            <Vertex pos="14.3668 15.4216 -3.5" />
                            <Vertex pos="14.3668 15.4216 2.5" />
                            <Vertex pos="12.3668 15.4216 2.5" />
                            <Vertex pos="12.3668 7.42161 -3.5" />
                            <Vertex pos="12.3668 7.42161 2.5" />
                            <Vertex pos="14.3668 7.42161 2.5" />
                            <Vertex pos="14.3668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="864" plane="0 1 -0 -15.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="865" plane="-1 0 0 12.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="866" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="867" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 7" />
                        </Face>
                        <Face id="868" plane="1 0 0 -14.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="869" plane="0 -1 0 7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1631" owner="0" type="0" pos="-2.87547 15.6894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -2.87547 0 1.3 0 15.6894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="433" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.36685 10.4216 -3.5" />
                            <Vertex pos="0.36685 10.4216 2.5" />
                            <Vertex pos="0.36685 12.4216 2.5" />
                            <Vertex pos="0.36685 12.4216 -3.5" />
                            <Vertex pos="-1.63315 12.4216 -3.5" />
                            <Vertex pos="-1.63315 12.4216 2.5" />
                            <Vertex pos="-1.63315 10.4216 2.5" />
                            <Vertex pos="-1.63315 10.4216 -3.5" />
                        </Vertices>
                        <Face id="426" plane="1 -0 0 -0.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="427" plane="0 1 -0 -12.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="428" plane="-0 -1 -0 10.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="429" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="430" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="431" plane="-1 0 0 -1.63315" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1632" owner="0" type="0" pos="-2.87547 15.6894 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -2.87547 0 1.3 0 15.6894 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="433" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.63315 10.4216 -3.5" />
                            <Vertex pos="-3.63315 12.4216 -3.5" />
                            <Vertex pos="-3.63315 12.4216 2.5" />
                            <Vertex pos="-3.63315 10.4216 2.5" />
                            <Vertex pos="-1.63315 12.4216 -3.5" />
                            <Vertex pos="-1.63315 12.4216 2.5" />
                            <Vertex pos="-1.63315 10.4216 2.5" />
                            <Vertex pos="-1.63315 10.4216 -3.5" />
                        </Vertices>
                        <Face id="426" plane="-1 0 0 -3.63315" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="427" plane="0 1 -0 -12.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="428" plane="-0 -1 -0 10.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="429" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="430" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="431" plane="1 -0 0 1.63315" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1634" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="283" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.13315 1.42161 -3.5" />
                            <Vertex pos="-7.13315 3.42161 -3.5" />
                            <Vertex pos="-7.13315 3.42161 2.5" />
                            <Vertex pos="-7.13315 1.42161 2.5" />
                            <Vertex pos="-5.13315 3.42161 2.5" />
                            <Vertex pos="-5.13315 3.42161 -3.5" />
                            <Vertex pos="-5.13315 1.42161 2.5" />
                            <Vertex pos="-5.13315 1.42161 -3.5" />
                        </Vertices>
                        <Face id="276" plane="-1 0 0 -7.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="277" plane="-0 1 0 -3.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="278" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="279" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="280" plane="0 -1 0 1.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="281" plane="1 -0 0 5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1637" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="511" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.63315 26.4216 -3.5" />
                            <Vertex pos="-2.63315 26.4216 2.5" />
                            <Vertex pos="-2.63315 28.4216 2.5" />
                            <Vertex pos="-2.63315 28.4216 -3.5" />
                            <Vertex pos="-4.63315 28.4216 -3.5" />
                            <Vertex pos="-4.63315 28.4216 2.5" />
                            <Vertex pos="-4.63315 26.4216 2.5" />
                            <Vertex pos="-4.63315 26.4216 -3.5" />
                        </Vertices>
                        <Face id="504" plane="1 -0 0 2.63315" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="505" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="506" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="507" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="508" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="509" plane="-1 0 0 -4.63315" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1638" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="511" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8.63315 26.4216 -3.5" />
                            <Vertex pos="-8.63315 28.4216 -3.5" />
                            <Vertex pos="-8.63315 28.4216 2.5" />
                            <Vertex pos="-8.63315 26.4216 2.5" />
                            <Vertex pos="-4.63315 28.4216 -3.5" />
                            <Vertex pos="-4.63315 28.4216 2.5" />
                            <Vertex pos="-4.63315 26.4216 2.5" />
                            <Vertex pos="-4.63315 26.4216 -3.5" />
                        </Vertices>
                        <Face id="504" plane="-1 0 0 -8.63315" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="505" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="506" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="507" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="508" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="509" plane="1 -0 0 4.63315" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1639" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="866" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.3668 13.4216 2.5" />
                            <Vertex pos="8.3668 13.4216 -3.5" />
                            <Vertex pos="8.3668 11.4216 -3.5" />
                            <Vertex pos="8.3668 11.4216 2.5" />
                            <Vertex pos="6.3668 13.4216 -3.5" />
                            <Vertex pos="6.3668 13.4216 2.5" />
                            <Vertex pos="6.3668 11.4216 2.5" />
                            <Vertex pos="6.3668 11.4216 -3.5" />
                        </Vertices>
                        <Face id="859" plane="1 0 -0 -8.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="860" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="861" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 0 3 6" />
                        </Face>
                        <Face id="862" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 7 2" />
                        </Face>
                        <Face id="863" plane="0 -1 0 11.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 7 6 3" />
                        </Face>
                        <Face id="864" plane="-1 0 0 6.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1640" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="866" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.3668 11.4216 -3.5" />
                            <Vertex pos="0.3668 13.4216 -3.5" />
                            <Vertex pos="0.3668 13.4216 2.5" />
                            <Vertex pos="0.3668 11.4216 2.5" />
                            <Vertex pos="6.3668 13.4216 -3.5" />
                            <Vertex pos="6.3668 13.4216 2.5" />
                            <Vertex pos="6.3668 11.4216 2.5" />
                            <Vertex pos="6.3668 11.4216 -3.5" />
                        </Vertices>
                        <Face id="859" plane="-1 0 0 0.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="860" plane="0 1 -0 -13.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="861" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="862" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="863" plane="0 -1 0 11.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="864" plane="1 -0 0 -6.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1642" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="877" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.3668 3.42161 -3.5" />
                            <Vertex pos="4.3668 9.42161 -3.5" />
                            <Vertex pos="4.3668 9.42161 2.5" />
                            <Vertex pos="4.3668 3.42161 2.5" />
                            <Vertex pos="6.3668 3.42161 2.5" />
                            <Vertex pos="6.3668 3.42161 -3.5" />
                            <Vertex pos="6.3668 9.42161 2.5" />
                            <Vertex pos="6.3668 9.42161 -3.5" />
                        </Vertices>
                        <Face id="870" plane="-1 0 0 4.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="871" plane="-0 -1 -0 3.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="872" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="873" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 5 7" />
                        </Face>
                        <Face id="874" plane="-0 1 0 -9.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="875" plane="1 0 0 -6.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1643" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="235" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.86685 -0.57839 -3.5" />
                            <Vertex pos="4.86685 -0.57839 -3.5" />
                            <Vertex pos="4.86685 -0.57839 2.5" />
                            <Vertex pos="2.86685 -0.57839 2.5" />
                            <Vertex pos="4.86685 -2.57839 2.5" />
                            <Vertex pos="4.86685 -2.57839 -3.5" />
                            <Vertex pos="2.86685 -2.57839 2.5" />
                            <Vertex pos="2.86685 -2.57839 -3.5" />
                        </Vertices>
                        <Face id="228" plane="0 1 -0 0.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="229" plane="1 0 0 -4.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="230" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="231" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="232" plane="-1 0 0 2.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="233" plane="0 -1 0 -2.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1645" owner="0" type="0" pos="4.92453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 4.92453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="631" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.36685 -0.0783902 2.5" />
                            <Vertex pos="4.36685 -0.0783899 -3.5" />
                            <Vertex pos="6.36685 -0.0783902 -3.5" />
                            <Vertex pos="6.36685 -0.0783899 2.5" />
                            <Vertex pos="6.36685 -2.07839 2.5" />
                            <Vertex pos="6.36685 -2.07839 -3.5" />
                            <Vertex pos="4.36685 -2.07839 -3.5" />
                            <Vertex pos="4.36685 -2.07839 2.5" />
                        </Vertices>
                        <Face id="624" plane="1.52737e-007 1 5.09123e-008 0.0783894" album="MyAlbum" material="images (3)" texgens="-1 0 0 96 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="625" plane="1 0 0 -6.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 96 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="626" plane="-1 0 0 4.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 96 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="627" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="628" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="629" plane="-0 -1 -0 -2.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 96 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1646" owner="0" type="0" pos="4.92453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 4.92453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="631" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.36685 -4.07839 2.5" />
                            <Vertex pos="6.36685 -4.07839 2.5" />
                            <Vertex pos="6.36685 -4.07839 -3.5" />
                            <Vertex pos="4.36685 -4.07839 -3.5" />
                            <Vertex pos="6.36685 -2.07839 2.5" />
                            <Vertex pos="6.36685 -2.07839 -3.5" />
                            <Vertex pos="4.36685 -2.07839 -3.5" />
                            <Vertex pos="4.36685 -2.07839 2.5" />
                        </Vertices>
                        <Face id="624" plane="-0 -1 -0 -4.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 96 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="625" plane="1 0 0 -6.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 96 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="626" plane="-1 0 0 4.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 96 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="627" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="628" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="629" plane="0 1 0 2.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 96 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1647" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="289" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.13315 -0.57839 -3.5" />
                            <Vertex pos="-1.13315 -0.57839 2.5" />
                            <Vertex pos="-3.13315 -0.57839 2.5" />
                            <Vertex pos="-3.13315 -0.57839 -3.5" />
                            <Vertex pos="-3.13315 -2.57839 2.5" />
                            <Vertex pos="-3.13315 -2.57839 -3.5" />
                            <Vertex pos="-1.13315 -2.57839 2.5" />
                            <Vertex pos="-1.13315 -2.57839 -3.5" />
                        </Vertices>
                        <Face id="282" plane="0 1 0 0.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="283" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="284" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="285" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="286" plane="1 0 0 1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="287" plane="0 -1 0 -2.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1648" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="289" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.13315 -4.57839 -3.5" />
                            <Vertex pos="-3.13315 -4.57839 -3.5" />
                            <Vertex pos="-3.13315 -4.57839 2.5" />
                            <Vertex pos="-1.13315 -4.57839 2.5" />
                            <Vertex pos="-3.13315 -2.57839 2.5" />
                            <Vertex pos="-3.13315 -2.57839 -3.5" />
                            <Vertex pos="-1.13315 -2.57839 2.5" />
                            <Vertex pos="-1.13315 -2.57839 -3.5" />
                        </Vertices>
                        <Face id="282" plane="0 -1 0 -4.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="283" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="284" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="285" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 5 1" />
                        </Face>
                        <Face id="286" plane="1 0 0 1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="287" plane="0 1 0 2.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1649" owner="0" type="0" pos="7.52453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 7.52453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="289" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="18.3668 -0.0783901 -3.5" />
                            <Vertex pos="20.3668 -0.0783901 -3.5" />
                            <Vertex pos="20.3668 -0.0783901 2.5" />
                            <Vertex pos="18.3668 -0.0783901 2.5" />
                            <Vertex pos="20.3668 -2.07839 2.5" />
                            <Vertex pos="20.3668 -2.07839 -3.5" />
                            <Vertex pos="18.3668 -2.07839 2.5" />
                            <Vertex pos="18.3668 -2.07839 -3.5" />
                        </Vertices>
                        <Face id="282" plane="0 1 -0 0.0783901" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="283" plane="1 0 0 -20.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="284" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="285" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="286" plane="-1 0 0 18.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="287" plane="0 -1 0 -2.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1653" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="451" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 2.42161 -3.5" />
                            <Vertex pos="33.3668 2.42161 -3.5" />
                            <Vertex pos="33.3668 2.42161 2.5" />
                            <Vertex pos="31.3668 2.42161 2.5" />
                            <Vertex pos="33.3668 -3.57839 2.5" />
                            <Vertex pos="33.3668 -3.57839 -3.5" />
                            <Vertex pos="31.3668 -3.57839 2.5" />
                            <Vertex pos="31.3668 -3.57839 -3.5" />
                        </Vertices>
                        <Face id="444" plane="0 1 -0 -2.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="445" plane="1 0 0 -33.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="446" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="447" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="448" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="449" plane="0 -1 0 -3.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1655" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="499" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 0.42161 -3.5" />
                            <Vertex pos="-30.6332 0.42161 2.5" />
                            <Vertex pos="-32.6332 0.42161 2.5" />
                            <Vertex pos="-32.6332 0.42161 -3.5" />
                            <Vertex pos="-32.6332 -3.57839 -3.5" />
                            <Vertex pos="-32.6332 -3.57839 2.5" />
                            <Vertex pos="-30.6332 -3.57839 2.5" />
                            <Vertex pos="-30.6332 -3.57839 -3.5" />
                        </Vertices>
                        <Face id="492" plane="0 1 0 -0.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="493" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="494" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="495" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="496" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="497" plane="0 -1 0 -3.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1657" owner="0" type="0" pos="17.9245 -5.76063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.9245 0 1.3 0 -5.76063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1981" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.3668 6.92161 -3.5" />
                            <Vertex pos="16.3668 6.92161 -3.5" />
                            <Vertex pos="16.3668 6.92161 2.5" />
                            <Vertex pos="14.3668 6.92161 2.5" />
                            <Vertex pos="16.3668 2.92161 2.5" />
                            <Vertex pos="16.3668 2.92161 -3.5" />
                            <Vertex pos="14.3668 2.92161 -3.5" />
                            <Vertex pos="14.3668 2.92161 2.5" />
                        </Vertices>
                        <Face id="1974" plane="0 1 -0 -6.92161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1975" plane="1 0 0 -16.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="1976" plane="-1 0 0 14.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="1977" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="1978" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="1979" plane="-0 -1 -0 2.92161" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1661" owner="0" type="0" pos="7.52453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 7.52453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="295" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="18.3668 -2.07839 -3.5" />
                            <Vertex pos="20.3668 -2.07839 -3.5" />
                            <Vertex pos="20.3668 -2.07839 2.5" />
                            <Vertex pos="18.3668 -2.07839 2.5" />
                            <Vertex pos="20.3668 -6.07839 2.5" />
                            <Vertex pos="20.3668 -6.07839 -3.5" />
                            <Vertex pos="18.3668 -6.07839 2.5" />
                            <Vertex pos="18.3668 -6.07839 -3.5" />
                        </Vertices>
                        <Face id="288" plane="0 1 -0 2.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="289" plane="1 0 0 -20.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="290" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="291" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="292" plane="-1 0 0 18.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="293" plane="0 -1 0 -6.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1662" owner="0" type="0" pos="7.52453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 7.52453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="295" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="18.3668 -8.07839 -3.5" />
                            <Vertex pos="18.3668 -8.07839 2.5" />
                            <Vertex pos="20.3668 -8.07839 2.5" />
                            <Vertex pos="20.3668 -8.07839 -3.5" />
                            <Vertex pos="20.3668 -6.07839 2.5" />
                            <Vertex pos="20.3668 -6.07839 -3.5" />
                            <Vertex pos="18.3668 -6.07839 2.5" />
                            <Vertex pos="18.3668 -6.07839 -3.5" />
                        </Vertices>
                        <Face id="288" plane="0 -1 0 -8.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="289" plane="1 0 0 -20.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="290" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="291" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="292" plane="-1 0 0 18.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="293" plane="0 1 -0 6.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1663" owner="0" type="0" pos="-11.3255 0.089368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 0.089368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1009" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-17.1332 -1.57839 -3.5" />
                            <Vertex pos="-17.1332 -1.57839 2.5" />
                            <Vertex pos="-19.1332 -1.57839 2.5" />
                            <Vertex pos="-19.1332 -1.57839 -3.5" />
                            <Vertex pos="-19.1332 -5.57839 -3.5" />
                            <Vertex pos="-19.1332 -5.57839 2.5" />
                            <Vertex pos="-17.1332 -5.57839 2.5" />
                            <Vertex pos="-17.1332 -5.57839 -3.5" />
                        </Vertices>
                        <Face id="1002" plane="0 1 0 1.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1003" plane="-1 0 0 -19.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1004" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1005" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="1006" plane="1 0 0 17.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="1007" plane="0 -1 0 -5.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1665" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="457" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 -3.57839 -3.5" />
                            <Vertex pos="33.3668 -3.57839 -3.5" />
                            <Vertex pos="33.3668 -3.57839 2.5" />
                            <Vertex pos="31.3668 -3.57839 2.5" />
                            <Vertex pos="33.3668 -7.57839 2.5" />
                            <Vertex pos="33.3668 -7.57839 -3.5" />
                            <Vertex pos="31.3668 -7.57839 2.5" />
                            <Vertex pos="31.3668 -7.57839 -3.5" />
                        </Vertices>
                        <Face id="450" plane="0 1 -0 3.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="451" plane="1 0 0 -33.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="452" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="453" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="454" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="455" plane="0 -1 0 -7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1667" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="505" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 -3.57839 -3.5" />
                            <Vertex pos="-30.6332 -3.57839 2.5" />
                            <Vertex pos="-32.6332 -3.57839 2.5" />
                            <Vertex pos="-32.6332 -3.57839 -3.5" />
                            <Vertex pos="-32.6332 -7.57839 -3.5" />
                            <Vertex pos="-32.6332 -7.57839 2.5" />
                            <Vertex pos="-30.6332 -7.57839 2.5" />
                            <Vertex pos="-30.6332 -7.57839 -3.5" />
                        </Vertices>
                        <Face id="498" plane="0 1 0 3.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="499" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="500" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="501" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="502" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="503" plane="0 -1 0 -7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1669" owner="0" type="0" pos="17.9245 -5.76063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.9245 0 1.3 0 -5.76063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1987" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.3668 2.92161 2.5" />
                            <Vertex pos="14.3668 2.92161 -3.5" />
                            <Vertex pos="16.3668 2.92161 -3.5" />
                            <Vertex pos="16.3668 2.92161 2.5" />
                            <Vertex pos="16.3668 -1.07839 2.5" />
                            <Vertex pos="16.3668 -1.07839 -3.5" />
                            <Vertex pos="14.3668 -1.07839 -3.5" />
                            <Vertex pos="14.3668 -1.07839 2.5" />
                        </Vertices>
                        <Face id="1980" plane="0 1 0 -2.92161" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1981" plane="1 0 0 -16.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1982" plane="-1 0 0 14.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="1983" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="1984" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1985" plane="-0 -1 -0 -1.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1672" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="283" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.13315 -4.57839 2.5" />
                            <Vertex pos="-7.13315 -6.57839 2.5" />
                            <Vertex pos="-7.13315 -6.57839 -3.5" />
                            <Vertex pos="-7.13315 -4.57839 -3.5" />
                            <Vertex pos="-5.13315 -6.57839 2.5" />
                            <Vertex pos="-5.13315 -6.57839 -3.5" />
                            <Vertex pos="-5.13315 -4.57839 2.5" />
                            <Vertex pos="-5.13315 -4.57839 -3.5" />
                        </Vertices>
                        <Face id="276" plane="-1 0 0 -7.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="277" plane="-0 -1 -0 -6.57839" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="278" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="279" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 7 3" />
                        </Face>
                        <Face id="280" plane="-0 1 0 4.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="281" plane="1 0 0 5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1673" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="289" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.13315 3.42161 -3.5" />
                            <Vertex pos="-1.13315 1.42161 -3.5" />
                            <Vertex pos="-1.13315 1.42161 2.5" />
                            <Vertex pos="-1.13315 3.42161 2.5" />
                            <Vertex pos="-3.13315 3.42161 2.5" />
                            <Vertex pos="-3.13315 3.42161 -3.5" />
                            <Vertex pos="-3.13315 1.42161 2.5" />
                            <Vertex pos="-3.13315 1.42161 -3.5" />
                        </Vertices>
                        <Face id="282" plane="1 0 0 1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="283" plane="0 1 0 -3.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="284" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="285" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 5 7" />
                        </Face>
                        <Face id="286" plane="0 -1 0 1.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="287" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1674" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="289" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5.13315 1.42161 -3.5" />
                            <Vertex pos="-5.13315 3.42161 -3.5" />
                            <Vertex pos="-5.13315 3.42161 2.5" />
                            <Vertex pos="-5.13315 1.42161 2.5" />
                            <Vertex pos="-3.13315 3.42161 2.5" />
                            <Vertex pos="-3.13315 3.42161 -3.5" />
                            <Vertex pos="-3.13315 1.42161 2.5" />
                            <Vertex pos="-3.13315 1.42161 -3.5" />
                        </Vertices>
                        <Face id="282" plane="-1 0 0 -5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="283" plane="-0 1 0 -3.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="284" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="285" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="286" plane="0 -1 0 1.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="287" plane="1 -0 0 3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1675" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="307" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.13315 7.42161 -3.5" />
                            <Vertex pos="-1.13315 5.42161 -3.5" />
                            <Vertex pos="-1.13315 5.42161 2.5" />
                            <Vertex pos="-1.13315 7.42161 2.5" />
                            <Vertex pos="-3.13315 7.42161 2.5" />
                            <Vertex pos="-3.13315 7.42161 -3.5" />
                            <Vertex pos="-3.13315 5.42161 2.5" />
                            <Vertex pos="-3.13315 5.42161 -3.5" />
                        </Vertices>
                        <Face id="300" plane="1 0 0 1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="301" plane="0 1 0 -7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="302" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="303" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 5 7" />
                        </Face>
                        <Face id="304" plane="0 -1 0 5.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="305" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1676" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="307" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5.13315 5.42161 -3.5" />
                            <Vertex pos="-5.13315 7.42161 -3.5" />
                            <Vertex pos="-5.13315 7.42161 2.5" />
                            <Vertex pos="-5.13315 5.42161 2.5" />
                            <Vertex pos="-3.13315 7.42161 2.5" />
                            <Vertex pos="-3.13315 7.42161 -3.5" />
                            <Vertex pos="-3.13315 5.42161 2.5" />
                            <Vertex pos="-3.13315 5.42161 -3.5" />
                        </Vertices>
                        <Face id="300" plane="-1 0 0 -5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="301" plane="-0 1 0 -7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="302" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="303" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="304" plane="0 -1 0 5.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="305" plane="1 -0 0 3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1678" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="883" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.3668 7.42161 -3.5" />
                            <Vertex pos="6.3668 7.42161 2.5" />
                            <Vertex pos="6.3668 5.42161 2.5" />
                            <Vertex pos="6.3668 5.42161 -3.5" />
                            <Vertex pos="8.3668 5.42161 2.5" />
                            <Vertex pos="8.3668 5.42161 -3.5" />
                            <Vertex pos="8.3668 7.42161 2.5" />
                            <Vertex pos="8.3668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="876" plane="-1 -0 -0 6.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="877" plane="-0 -1 -0 5.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="878" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="879" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="880" plane="-0 1 0 -7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="881" plane="1 0 0 -8.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1679" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="289" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.13315 -4.57839 -3.5" />
                            <Vertex pos="-1.13315 -6.57839 -3.5" />
                            <Vertex pos="-1.13315 -6.57839 2.5" />
                            <Vertex pos="-1.13315 -4.57839 2.5" />
                            <Vertex pos="-3.13315 -6.57839 2.5" />
                            <Vertex pos="-3.13315 -6.57839 -3.5" />
                            <Vertex pos="-3.13315 -4.57839 2.5" />
                            <Vertex pos="-3.13315 -4.57839 -3.5" />
                        </Vertices>
                        <Face id="282" plane="1 0 0 1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="283" plane="-0 -1 -0 -6.57839" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="284" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="285" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="286" plane="0 1 0 4.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="287" plane="-1 -0 -0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1681" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="367" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-15.1332 0.42161 -3.5" />
                            <Vertex pos="-15.1332 0.42161 2.5" />
                            <Vertex pos="-17.1332 0.42161 2.5" />
                            <Vertex pos="-17.1332 0.42161 -3.5" />
                            <Vertex pos="-17.1332 -1.57839 2.5" />
                            <Vertex pos="-17.1332 -1.57839 -3.5" />
                            <Vertex pos="-15.1332 -1.57839 2.5" />
                            <Vertex pos="-15.1332 -1.57839 -3.5" />
                        </Vertices>
                        <Face id="360" plane="0 1 0 -0.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="361" plane="-1 0 0 -17.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="362" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="363" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="364" plane="1 0 0 15.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="365" plane="0 -1 0 -1.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1683" owner="0" type="0" pos="-11.3255 0.089368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 0.089368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1015" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-17.1332 -5.57839 -3.5" />
                            <Vertex pos="-17.1332 -5.57839 2.5" />
                            <Vertex pos="-19.1332 -5.57839 2.5" />
                            <Vertex pos="-19.1332 -5.57839 -3.5" />
                            <Vertex pos="-19.1332 -7.57839 -3.5" />
                            <Vertex pos="-19.1332 -7.57839 2.5" />
                            <Vertex pos="-17.1332 -7.57839 2.5" />
                            <Vertex pos="-17.1332 -7.57839 -3.5" />
                        </Vertices>
                        <Face id="1008" plane="0 1 0 5.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1009" plane="-1 0 0 -19.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1010" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1011" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="1012" plane="1 0 0 17.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="1013" plane="0 -1 0 -7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1684" owner="0" type="0" pos="-11.3255 0.089368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 0.089368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1015" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-17.1332 -9.57839 -3.5" />
                            <Vertex pos="-19.1332 -9.57839 -3.5" />
                            <Vertex pos="-19.1332 -9.57839 2.5" />
                            <Vertex pos="-17.1332 -9.57839 2.5" />
                            <Vertex pos="-19.1332 -7.57839 -3.5" />
                            <Vertex pos="-19.1332 -7.57839 2.5" />
                            <Vertex pos="-17.1332 -7.57839 2.5" />
                            <Vertex pos="-17.1332 -7.57839 -3.5" />
                        </Vertices>
                        <Face id="1008" plane="0 -1 0 -9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1009" plane="-1 0 0 -19.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1010" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="1011" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="1012" plane="1 0 0 17.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="1013" plane="0 1 0 7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1685" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 -7.57839 -3.5" />
                            <Vertex pos="33.3668 -7.57839 -3.5" />
                            <Vertex pos="33.3668 -7.57839 2.5" />
                            <Vertex pos="31.3668 -7.57839 2.5" />
                            <Vertex pos="33.3668 -9.57839 2.5" />
                            <Vertex pos="33.3668 -9.57839 -3.5" />
                            <Vertex pos="31.3668 -9.57839 2.5" />
                            <Vertex pos="31.3668 -9.57839 -3.5" />
                        </Vertices>
                        <Face id="456" plane="0 1 -0 7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="1 0 0 -33.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="458" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="459" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="460" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="461" plane="0 -1 0 -9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1686" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 -11.5784 -3.5" />
                            <Vertex pos="31.3668 -11.5784 2.5" />
                            <Vertex pos="33.3668 -11.5784 2.5" />
                            <Vertex pos="33.3668 -11.5784 -3.5" />
                            <Vertex pos="33.3668 -9.57839 2.5" />
                            <Vertex pos="33.3668 -9.57839 -3.5" />
                            <Vertex pos="31.3668 -9.57839 2.5" />
                            <Vertex pos="31.3668 -9.57839 -3.5" />
                        </Vertices>
                        <Face id="456" plane="0 -1 0 -11.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="1 0 0 -33.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="458" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="459" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="460" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="461" plane="0 1 -0 9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1687" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="511" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 -7.57839 -3.5" />
                            <Vertex pos="-30.6332 -7.57839 2.5" />
                            <Vertex pos="-32.6332 -7.57839 2.5" />
                            <Vertex pos="-32.6332 -7.57839 -3.5" />
                            <Vertex pos="-32.6332 -9.57839 -3.5" />
                            <Vertex pos="-32.6332 -9.57839 2.5" />
                            <Vertex pos="-30.6332 -9.57839 2.5" />
                            <Vertex pos="-30.6332 -9.57839 -3.5" />
                        </Vertices>
                        <Face id="504" plane="0 1 0 7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="505" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="506" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="507" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="508" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="509" plane="0 -1 0 -9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1688" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="511" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 -11.5784 -3.5" />
                            <Vertex pos="-32.6332 -11.5784 -3.5" />
                            <Vertex pos="-32.6332 -11.5784 2.5" />
                            <Vertex pos="-30.6332 -11.5784 2.5" />
                            <Vertex pos="-32.6332 -9.57839 -3.5" />
                            <Vertex pos="-32.6332 -9.57839 2.5" />
                            <Vertex pos="-30.6332 -9.57839 2.5" />
                            <Vertex pos="-30.6332 -9.57839 -3.5" />
                        </Vertices>
                        <Face id="504" plane="0 -1 0 -11.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="505" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="506" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="507" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="508" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="509" plane="0 1 0 9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1689" owner="0" type="0" pos="17.9245 -5.76063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.9245 0 1.3 0 -5.76063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1993" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.3668 -1.07839 2.5" />
                            <Vertex pos="14.3668 -1.07839 -3.5" />
                            <Vertex pos="16.3668 -1.07839 -3.5" />
                            <Vertex pos="16.3668 -1.07839 2.5" />
                            <Vertex pos="16.3668 -3.07839 2.5" />
                            <Vertex pos="16.3668 -3.07839 -3.5" />
                            <Vertex pos="14.3668 -3.07839 -3.5" />
                            <Vertex pos="14.3668 -3.07839 2.5" />
                        </Vertices>
                        <Face id="1986" plane="0 1 0 1.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1987" plane="1 0 0 -16.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1988" plane="-1 0 0 14.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="1989" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="1990" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1991" plane="-0 -1 -0 -3.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1690" owner="0" type="0" pos="17.9245 -5.76063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 17.9245 0 1.3 0 -5.76063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1993" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.3668 -5.07839 2.5" />
                            <Vertex pos="16.3668 -5.07839 2.5" />
                            <Vertex pos="16.3668 -5.07839 -3.5" />
                            <Vertex pos="14.3668 -5.07839 -3.5" />
                            <Vertex pos="16.3668 -3.07839 2.5" />
                            <Vertex pos="16.3668 -3.07839 -3.5" />
                            <Vertex pos="14.3668 -3.07839 -3.5" />
                            <Vertex pos="14.3668 -3.07839 2.5" />
                        </Vertices>
                        <Face id="1986" plane="-0 -1 -0 -5.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1987" plane="1 0 0 -16.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1988" plane="-1 0 0 14.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="1989" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="1990" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -192 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="1991" plane="0 1 0 3.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1693" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="301" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.13315 -4.57839 2.5" />
                            <Vertex pos="-5.13315 -4.57839 2.5" />
                            <Vertex pos="-5.13315 -4.57839 -3.5" />
                            <Vertex pos="-3.13315 -4.57839 -3.5" />
                            <Vertex pos="-5.13315 -8.57839 2.5" />
                            <Vertex pos="-5.13315 -8.57839 -3.5" />
                            <Vertex pos="-3.13315 -8.57839 2.5" />
                            <Vertex pos="-3.13315 -8.57839 -3.5" />
                        </Vertices>
                        <Face id="294" plane="-0 1 0 4.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="295" plane="-1 -0 -0 -5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="296" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="297" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 2 5" />
                        </Face>
                        <Face id="298" plane="1 0 0 3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="299" plane="0 -1 0 -8.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1697" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="241" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.86685 -2.57839 -3.5" />
                            <Vertex pos="4.86685 -2.57839 -3.5" />
                            <Vertex pos="4.86685 -2.57839 2.5" />
                            <Vertex pos="2.86685 -2.57839 2.5" />
                            <Vertex pos="4.86685 -4.57839 2.5" />
                            <Vertex pos="4.86685 -4.57839 -3.5" />
                            <Vertex pos="2.86685 -4.57839 2.5" />
                            <Vertex pos="2.86685 -4.57839 -3.5" />
                        </Vertices>
                        <Face id="234" plane="0 1 -0 2.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="235" plane="1 0 0 -4.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="236" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="237" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="238" plane="-1 0 0 2.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="239" plane="0 -1 0 -4.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1699" owner="0" type="0" pos="4.92453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 4.92453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="625" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="6.36685 -4.07839 -3.5" />
                            <Vertex pos="6.36685 -4.07839 2.5" />
                            <Vertex pos="6.36685 -6.07839 2.5" />
                            <Vertex pos="6.36685 -6.07839 -3.5" />
                            <Vertex pos="8.36685 -6.07839 2.5" />
                            <Vertex pos="8.36685 -6.07839 -3.5" />
                            <Vertex pos="8.36685 -4.07839 2.5" />
                            <Vertex pos="8.36685 -4.07839 -3.5" />
                        </Vertices>
                        <Face id="618" plane="-1 -0 -0 6.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="619" plane="-0 -1 -0 -6.07839" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="620" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 4 2" />
                        </Face>
                        <Face id="621" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="622" plane="0 1 -0 4.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 96 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="623" plane="1 0 0 -8.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1700" owner="0" type="0" pos="4.92453 0.739368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 4.92453 0 1.3 0 0.739368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="625" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="18.3668 -4.07839 -3.5" />
                            <Vertex pos="18.3668 -6.07839 -3.5" />
                            <Vertex pos="18.3668 -6.07839 2.5" />
                            <Vertex pos="18.3668 -4.07839 2.5" />
                            <Vertex pos="8.36685 -6.07839 2.5" />
                            <Vertex pos="8.36685 -6.07839 -3.5" />
                            <Vertex pos="8.36685 -4.07839 2.5" />
                            <Vertex pos="8.36685 -4.07839 -3.5" />
                        </Vertices>
                        <Face id="618" plane="1 0 0 -18.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="619" plane="-0 -1 -0 -6.07839" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="620" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 4" />
                        </Face>
                        <Face id="621" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -96 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="622" plane="0 1 -0 4.07839" album="MyAlbum" material="images (3)" texgens="-1 0 0 96 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="623" plane="-1 -0 -0 8.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1702" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="343" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.8668 -13.5784 2.5" />
                            <Vertex pos="31.8668 -11.5784 2.5" />
                            <Vertex pos="31.8668 -11.5784 -3.5" />
                            <Vertex pos="31.8668 -13.5784 -3.5" />
                            <Vertex pos="17.8668 -13.5784 -3.5" />
                            <Vertex pos="17.8668 -13.5784 2.5" />
                            <Vertex pos="17.8668 -11.5784 2.5" />
                            <Vertex pos="17.8668 -11.5784 -3.5" />
                        </Vertices>
                        <Face id="336" plane="1 0 0 -31.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="337" plane="0 -1 0 -13.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="338" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 5 6" />
                        </Face>
                        <Face id="339" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 7 4" />
                        </Face>
                        <Face id="340" plane="0 1 0 11.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 6 7" />
                        </Face>
                        <Face id="341" plane="-1 -0 -0 17.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1703" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="349" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="15.8668 -21.5784 -3.5" />
                            <Vertex pos="15.8668 -19.5784 -3.5" />
                            <Vertex pos="15.8668 -19.5784 2.5" />
                            <Vertex pos="15.8668 -21.5784 2.5" />
                            <Vertex pos="17.8668 -19.5784 2.5" />
                            <Vertex pos="17.8668 -19.5784 -3.5" />
                            <Vertex pos="17.8668 -21.5784 2.5" />
                            <Vertex pos="17.8668 -21.5784 -3.5" />
                        </Vertices>
                        <Face id="342" plane="-1 0 0 15.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="343" plane="-0 1 0 19.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="344" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 4" />
                        </Face>
                        <Face id="345" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="346" plane="0 -1 0 -21.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="347" plane="1 -0 0 -17.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1704" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="349" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.8668 -21.5784 2.5" />
                            <Vertex pos="31.8668 -19.5784 2.5" />
                            <Vertex pos="31.8668 -19.5784 -3.5" />
                            <Vertex pos="31.8668 -21.5784 -3.5" />
                            <Vertex pos="17.8668 -19.5784 2.5" />
                            <Vertex pos="17.8668 -19.5784 -3.5" />
                            <Vertex pos="17.8668 -21.5784 2.5" />
                            <Vertex pos="17.8668 -21.5784 -3.5" />
                        </Vertices>
                        <Face id="342" plane="1 0 0 -31.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="343" plane="0 1 0 19.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="344" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 6 4" />
                        </Face>
                        <Face id="345" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="346" plane="0 -1 0 -21.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="347" plane="-1 0 0 17.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1705" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="511" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.38556 26.4216 -3.5" />
                            <Vertex pos="3.3879 28.4216 -3.5" />
                            <Vertex pos="3.3879 28.4216 2.5" />
                            <Vertex pos="3.38556 26.4216 2.5" />
                            <Vertex pos="11.3668 28.4216 -3.5" />
                            <Vertex pos="11.3668 28.4216 2.5" />
                            <Vertex pos="11.3668 26.4216 2.5" />
                            <Vertex pos="11.3668 26.4216 -3.5" />
                        </Vertices>
                        <Face id="504" plane="-0.999999 0.00117004 0 3.35464" album="MyAlbum" material="images (3)" texgens="0.00116959 0.999999 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="505" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="506" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="507" plane="0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="508" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="509" plane="1 -0 0 -11.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1706" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="511" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 26.4216 -3.5" />
                            <Vertex pos="31.3668 26.4216 2.5" />
                            <Vertex pos="31.3668 28.4216 2.5" />
                            <Vertex pos="31.3668 28.4216 -3.5" />
                            <Vertex pos="11.3668 28.4216 -3.5" />
                            <Vertex pos="11.3668 28.4216 2.5" />
                            <Vertex pos="11.3668 26.4216 2.5" />
                            <Vertex pos="11.3668 26.4216 -3.5" />
                        </Vertices>
                        <Face id="504" plane="1 -0 0 -31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="505" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="506" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="507" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="508" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="509" plane="-1 0 0 11.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1708" owner="0" type="0" pos="2.32453 -5.11063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 2.32453 0 1.3 0 -5.11063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="938" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="24.3668 -9.57839 2.5" />
                            <Vertex pos="24.3668 -7.57839 2.5" />
                            <Vertex pos="24.3668 -7.57839 -3.5" />
                            <Vertex pos="24.3668 -9.57839 -3.5" />
                            <Vertex pos="10.3668 -9.57839 2.5" />
                            <Vertex pos="10.3668 -9.57839 -3.5" />
                            <Vertex pos="10.3668 -7.57839 2.5" />
                            <Vertex pos="10.3668 -7.57839 -3.5" />
                        </Vertices>
                        <Face id="931" plane="1 0 0 -24.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="932" plane="-0 -1 -0 -9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="933" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="934" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 7 5" />
                        </Face>
                        <Face id="935" plane="0 1 -0 7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="936" plane="-1 -0 -0 10.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1711" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="871" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.3668 13.4216 -3.5" />
                            <Vertex pos="14.3668 15.4216 -3.5" />
                            <Vertex pos="14.3668 15.4216 2.5" />
                            <Vertex pos="14.3668 13.4216 2.5" />
                            <Vertex pos="22.3668 15.4216 -3.5" />
                            <Vertex pos="22.3668 15.4216 2.5" />
                            <Vertex pos="22.3668 13.4216 2.5" />
                            <Vertex pos="22.3668 13.4216 -3.5" />
                        </Vertices>
                        <Face id="864" plane="-1 0 0 14.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="865" plane="0 1 -0 -15.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="866" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="867" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="868" plane="-0 -1 -0 13.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="869" plane="1 -0 0 -22.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1712" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="871" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="40.3668 13.4216 2.5" />
                            <Vertex pos="40.3668 15.4216 2.5" />
                            <Vertex pos="40.3668 15.4216 -3.5" />
                            <Vertex pos="40.3668 13.4216 -3.5" />
                            <Vertex pos="22.3668 15.4216 -3.5" />
                            <Vertex pos="22.3668 15.4216 2.5" />
                            <Vertex pos="22.3668 13.4216 2.5" />
                            <Vertex pos="22.3668 13.4216 -3.5" />
                        </Vertices>
                        <Face id="864" plane="1 0 0 -40.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="865" plane="0 1 -0 -15.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="866" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 6 5" />
                        </Face>
                        <Face id="867" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="868" plane="-0 -1 -0 13.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="869" plane="-1 0 0 22.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1714" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="889" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="39.3668 5.42161 -3.5" />
                            <Vertex pos="39.3668 5.42161 2.5" />
                            <Vertex pos="39.3668 7.42161 2.5" />
                            <Vertex pos="39.3668 7.42161 -3.5" />
                            <Vertex pos="22.3668 5.42161 2.5" />
                            <Vertex pos="22.3668 5.42161 -3.5" />
                            <Vertex pos="22.3668 7.42161 2.5" />
                            <Vertex pos="22.3668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="882" plane="1 -0 0 -39.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="883" plane="-0 -1 -0 5.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="884" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 6 2" />
                        </Face>
                        <Face id="885" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 0 3 7" />
                        </Face>
                        <Face id="886" plane="0 1 0 -7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="887" plane="-1 -0 -0 22.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1715" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="373" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-15.1332 -1.57839 -3.5" />
                            <Vertex pos="-15.1332 -1.57839 2.5" />
                            <Vertex pos="-17.1332 -1.57839 2.5" />
                            <Vertex pos="-17.1332 -1.57839 -3.5" />
                            <Vertex pos="-17.1332 -3.57839 2.5" />
                            <Vertex pos="-17.1332 -3.57839 -3.5" />
                            <Vertex pos="-15.1332 -3.57839 2.5" />
                            <Vertex pos="-15.1332 -3.57839 -3.5" />
                        </Vertices>
                        <Face id="366" plane="0 1 0 1.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="367" plane="-1 0 0 -17.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="368" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="369" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="370" plane="1 0 0 15.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="371" plane="0 -1 0 -3.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1718" owner="0" type="0" pos="2.32453 -5.11063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 2.32453 0 1.3 0 -5.11063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="944" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.36685 -9.57839 -3.5" />
                            <Vertex pos="8.36685 -9.57839 2.5" />
                            <Vertex pos="10.3668 -9.57839 2.5" />
                            <Vertex pos="10.3668 -9.57839 -3.5" />
                            <Vertex pos="8.36685 -5.57839 -3.5" />
                            <Vertex pos="8.36685 -5.57839 2.5" />
                            <Vertex pos="10.3668 -5.57839 2.5" />
                            <Vertex pos="10.3668 -5.57839 -3.5" />
                        </Vertices>
                        <Face id="937" plane="0 -1 0 -9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="938" plane="-1 0 0 8.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="939" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 5 6" />
                        </Face>
                        <Face id="940" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 7" />
                        </Face>
                        <Face id="941" plane="1 0 0 -10.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="942" plane="0 1 0 5.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1720" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="349" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="17.8668 -13.5784 -3.5" />
                            <Vertex pos="15.8668 -13.5784 -3.5" />
                            <Vertex pos="15.8668 -13.5784 2.5" />
                            <Vertex pos="17.8668 -13.5784 2.5" />
                            <Vertex pos="15.8668 -9.57839 -3.5" />
                            <Vertex pos="15.8668 -9.57839 2.5" />
                            <Vertex pos="17.8668 -9.57839 2.5" />
                            <Vertex pos="17.8668 -9.57839 -3.5" />
                        </Vertices>
                        <Face id="342" plane="0 -1 0 -13.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="343" plane="-1 0 0 15.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="344" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="345" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="346" plane="1 0 0 -17.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="347" plane="0 1 0 9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1722" owner="0" type="0" pos="3.62453 -15.5106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 3.62453 0 1.3 0 -15.5106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="445" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.36685 -11.5784 2.5" />
                            <Vertex pos="5.36685 -11.5784 2.5" />
                            <Vertex pos="5.36685 -11.5784 -3.5" />
                            <Vertex pos="3.36685 -11.5784 -3.5" />
                            <Vertex pos="5.36685 -9.57836 2.5" />
                            <Vertex pos="5.36685 -9.57836 -3.5" />
                            <Vertex pos="3.36685 -9.57836 -3.5" />
                            <Vertex pos="3.36685 -9.57836 2.5" />
                        </Vertices>
                        <Face id="438" plane="-0 -1 -0 -11.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="439" plane="1 0 0 -5.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="440" plane="-1 0 0 3.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="441" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="442" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="443" plane="0 1 0 9.57836" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1723" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="451" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-28.6332 -19.5784 -3.5" />
                            <Vertex pos="-26.6332 -19.5784 -3.5" />
                            <Vertex pos="-26.6332 -19.5784 2.5" />
                            <Vertex pos="-28.6332 -19.5784 2.5" />
                            <Vertex pos="-28.6332 -23.5784 2.5" />
                            <Vertex pos="-28.6332 -23.5784 -3.5" />
                            <Vertex pos="-26.6332 -23.5784 2.5" />
                            <Vertex pos="-26.6332 -23.5784 -3.5" />
                        </Vertices>
                        <Face id="444" plane="0 1 -0 19.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="445" plane="-1 -0 -0 -28.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="446" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="447" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 5 7" />
                        </Face>
                        <Face id="448" plane="1 0 0 26.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="449" plane="0 -1 0 -23.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1725" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="481" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 -17.5784 -3.5" />
                            <Vertex pos="-30.6332 -17.5784 2.5" />
                            <Vertex pos="-32.6332 -17.5784 2.5" />
                            <Vertex pos="-32.6332 -17.5784 -3.5" />
                            <Vertex pos="-32.6332 -23.5784 -3.5" />
                            <Vertex pos="-32.6332 -23.5784 2.5" />
                            <Vertex pos="-30.6332 -23.5784 2.5" />
                            <Vertex pos="-30.6332 -23.5784 -3.5" />
                        </Vertices>
                        <Face id="474" plane="0 1 0 17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="475" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="476" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="477" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="478" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="479" plane="0 -1 0 -23.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1727" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="445" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 -13.5784 -3.5" />
                            <Vertex pos="33.3668 -13.5784 -3.5" />
                            <Vertex pos="33.3668 -13.5784 2.5" />
                            <Vertex pos="31.3668 -13.5784 2.5" />
                            <Vertex pos="33.3668 -23.5784 2.5" />
                            <Vertex pos="33.3668 -23.5784 -3.5" />
                            <Vertex pos="31.3668 -23.5784 2.5" />
                            <Vertex pos="31.3668 -23.5784 -3.5" />
                        </Vertices>
                        <Face id="438" plane="0 1 -0 13.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="439" plane="1 0 0 -33.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="440" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="441" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="442" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="443" plane="0 -1 0 -23.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1729" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="277" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-19.1332 -10.5784 -3.5" />
                            <Vertex pos="-19.1332 -10.5784 2.5" />
                            <Vertex pos="-21.1332 -10.5784 2.5" />
                            <Vertex pos="-21.1332 -10.5784 -3.5" />
                            <Vertex pos="-21.1332 -22.5784 2.5" />
                            <Vertex pos="-21.1332 -22.5784 -3.5" />
                            <Vertex pos="-19.1332 -22.5784 2.5" />
                            <Vertex pos="-19.1332 -22.5784 -3.5" />
                        </Vertices>
                        <Face id="270" plane="0 1 0 10.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="271" plane="-1 0 0 -21.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="272" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="273" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="274" plane="1 0 0 19.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="275" plane="0 -1 0 -22.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1731" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="313" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.13315 -7.57839 -3.5" />
                            <Vertex pos="-7.13315 -7.57839 2.5" />
                            <Vertex pos="-9.13315 -7.57839 2.5" />
                            <Vertex pos="-9.13315 -7.57839 -3.5" />
                            <Vertex pos="-9.13315 -15.5784 -3.5" />
                            <Vertex pos="-9.13315 -15.5784 2.5" />
                            <Vertex pos="-7.13315 -15.5784 2.5" />
                            <Vertex pos="-7.13315 -15.5784 -3.5" />
                        </Vertices>
                        <Face id="306" plane="0 1 0 7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="307" plane="-1 0 0 -9.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="308" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="309" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="310" plane="1 0 0 7.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="311" plane="0 -1 0 -15.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1733" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="379" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-15.1332 -3.57839 -3.5" />
                            <Vertex pos="-15.1332 -3.57839 2.5" />
                            <Vertex pos="-17.1332 -3.57839 2.5" />
                            <Vertex pos="-17.1332 -3.57839 -3.5" />
                            <Vertex pos="-17.1332 -15.5784 2.5" />
                            <Vertex pos="-17.1332 -15.5784 -3.5" />
                            <Vertex pos="-15.1332 -15.5784 2.5" />
                            <Vertex pos="-15.1332 -15.5784 -3.5" />
                        </Vertices>
                        <Face id="372" plane="0 1 0 3.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="373" plane="-1 0 0 -17.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="374" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="375" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="376" plane="1 0 0 15.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="377" plane="0 -1 0 -15.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1735" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="457" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-26.6332 -23.5784 -3.5" />
                            <Vertex pos="-26.6332 -23.5784 2.5" />
                            <Vertex pos="-28.6332 -23.5784 2.5" />
                            <Vertex pos="-28.6332 -23.5784 -3.5" />
                            <Vertex pos="-28.6332 -25.5784 2.5" />
                            <Vertex pos="-28.6332 -25.5784 -3.5" />
                            <Vertex pos="-26.6332 -25.5784 2.5" />
                            <Vertex pos="-26.6332 -25.5784 -3.5" />
                        </Vertices>
                        <Face id="450" plane="0 1 0 23.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="451" plane="-1 0 0 -28.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="452" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="453" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="454" plane="1 0 0 26.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="455" plane="0 -1 0 -25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1737" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="487" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 -23.5784 -3.5" />
                            <Vertex pos="-30.6332 -23.5784 2.5" />
                            <Vertex pos="-32.6332 -23.5784 2.5" />
                            <Vertex pos="-32.6332 -23.5784 -3.5" />
                            <Vertex pos="-32.6332 -25.5784 -3.5" />
                            <Vertex pos="-32.6332 -25.5784 2.5" />
                            <Vertex pos="-30.6332 -25.5784 2.5" />
                            <Vertex pos="-30.6332 -25.5784 -3.5" />
                        </Vertices>
                        <Face id="480" plane="0 1 0 23.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="481" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="482" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="483" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="484" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="485" plane="0 -1 0 -25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1739" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="451" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 -23.5784 -3.5" />
                            <Vertex pos="33.3668 -23.5784 -3.5" />
                            <Vertex pos="33.3668 -23.5784 2.5" />
                            <Vertex pos="31.3668 -23.5784 2.5" />
                            <Vertex pos="33.3668 -25.5784 2.5" />
                            <Vertex pos="33.3668 -25.5784 -3.5" />
                            <Vertex pos="31.3668 -25.5784 2.5" />
                            <Vertex pos="31.3668 -25.5784 -3.5" />
                        </Vertices>
                        <Face id="444" plane="0 1 -0 23.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="445" plane="1 0 0 -33.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="446" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="447" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="448" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="449" plane="0 -1 0 -25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1741" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="283" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-19.1332 -22.5784 -3.5" />
                            <Vertex pos="-19.1332 -22.5784 2.5" />
                            <Vertex pos="-21.1332 -22.5784 2.5" />
                            <Vertex pos="-21.1332 -22.5784 -3.5" />
                            <Vertex pos="-21.1332 -24.5784 2.5" />
                            <Vertex pos="-21.1332 -24.5784 -3.5" />
                            <Vertex pos="-19.1332 -24.5784 2.5" />
                            <Vertex pos="-19.1332 -24.5784 -3.5" />
                        </Vertices>
                        <Face id="276" plane="0 1 0 22.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="277" plane="-1 0 0 -21.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="278" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="279" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="280" plane="1 0 0 19.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="281" plane="0 -1 0 -24.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1743" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="319" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.13315 -15.5784 -3.5" />
                            <Vertex pos="-7.13315 -15.5784 2.5" />
                            <Vertex pos="-9.13315 -15.5784 2.5" />
                            <Vertex pos="-9.13315 -15.5784 -3.5" />
                            <Vertex pos="-9.13315 -17.5784 -3.5" />
                            <Vertex pos="-9.13315 -17.5784 2.5" />
                            <Vertex pos="-7.13315 -17.5784 2.5" />
                            <Vertex pos="-7.13315 -17.5784 -3.5" />
                        </Vertices>
                        <Face id="312" plane="0 1 0 15.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="313" plane="-1 0 0 -9.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="314" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="315" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="316" plane="1 0 0 7.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="317" plane="0 -1 0 -17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1745" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="385" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-15.1332 -15.5784 -3.5" />
                            <Vertex pos="-15.1332 -15.5784 2.5" />
                            <Vertex pos="-17.1332 -15.5784 2.5" />
                            <Vertex pos="-17.1332 -15.5784 -3.5" />
                            <Vertex pos="-17.1332 -17.5784 2.5" />
                            <Vertex pos="-17.1332 -17.5784 -3.5" />
                            <Vertex pos="-15.1332 -17.5784 2.5" />
                            <Vertex pos="-15.1332 -17.5784 -3.5" />
                        </Vertices>
                        <Face id="378" plane="0 1 0 15.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="379" plane="-1 0 0 -17.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="380" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="381" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="382" plane="1 0 0 15.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="383" plane="0 -1 0 -17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1747" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="517" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.36685 26.4216 -3.5" />
                            <Vertex pos="3.36685 26.4216 2.5" />
                            <Vertex pos="3.36685 28.4216 2.5" />
                            <Vertex pos="3.36685 28.4216 -3.5" />
                            <Vertex pos="1.36685 28.4216 -3.5" />
                            <Vertex pos="1.36685 28.4216 2.5" />
                            <Vertex pos="1.36685 26.4216 2.5" />
                            <Vertex pos="1.36685 26.4216 -3.5" />
                        </Vertices>
                        <Face id="510" plane="1 -0 0 -3.36685" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="511" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="512" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="513" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="514" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="515" plane="-1 0 0 1.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1748" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="517" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.63315 26.4216 -3.5" />
                            <Vertex pos="-0.63315 28.4216 -3.5" />
                            <Vertex pos="-0.63315 28.4216 2.5" />
                            <Vertex pos="-0.63315 26.4216 2.5" />
                            <Vertex pos="1.36685 28.4216 -3.5" />
                            <Vertex pos="1.36685 28.4216 2.5" />
                            <Vertex pos="1.36685 26.4216 2.5" />
                            <Vertex pos="1.36685 26.4216 -3.5" />
                        </Vertices>
                        <Face id="510" plane="-1 0 0 -0.63315" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="511" plane="0 1 -0 -28.4216" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="512" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="513" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="514" plane="0 -1 0 26.4216" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="515" plane="1 -0 0 -1.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1749" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="307" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.86685 7.42161 -3.5" />
                            <Vertex pos="2.86685 7.42161 2.5" />
                            <Vertex pos="2.86685 9.42161 2.5" />
                            <Vertex pos="2.86685 9.42161 -3.5" />
                            <Vertex pos="0.86685 9.42161 2.5" />
                            <Vertex pos="0.86685 9.42161 -3.5" />
                            <Vertex pos="0.86685 7.42161 2.5" />
                            <Vertex pos="0.86685 7.42161 -3.5" />
                        </Vertices>
                        <Face id="300" plane="1 -0 0 -2.86685" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="301" plane="-0 1 0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="302" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="303" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="304" plane="0 -1 0 7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="305" plane="-1 0 0 0.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1750" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="307" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.13783 7.42161 -3.5" />
                            <Vertex pos="-1.13549 9.42161 -3.5" />
                            <Vertex pos="-1.13549 9.42161 2.5" />
                            <Vertex pos="-1.13783 7.42161 2.5" />
                            <Vertex pos="0.86685 9.42161 2.5" />
                            <Vertex pos="0.86685 9.42161 -3.5" />
                            <Vertex pos="0.86685 7.42161 2.5" />
                            <Vertex pos="0.86685 7.42161 -3.5" />
                        </Vertices>
                        <Face id="300" plane="-0.999999 0.00117004 0 -1.14651" album="MyAlbum" material="images (3)" texgens="0.00116959 0.999999 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="301" plane="-0 1 0 -9.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="302" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="303" plane="0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="304" plane="0 -1 0 7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="305" plane="1 -0 0 -0.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1751" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="313" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="14.8668 -5.57839 -3.5" />
                            <Vertex pos="14.8668 -7.57839 -3.5" />
                            <Vertex pos="14.8668 -7.57839 2.5" />
                            <Vertex pos="14.8668 -5.57839 2.5" />
                            <Vertex pos="8.86685 -5.57839 2.5" />
                            <Vertex pos="8.86685 -5.57839 -3.5" />
                            <Vertex pos="8.86685 -7.57839 2.5" />
                            <Vertex pos="8.86685 -7.57839 -3.5" />
                        </Vertices>
                        <Face id="306" plane="1 0 0 -14.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="307" plane="-0 1 0 5.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="308" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="309" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 5 7" />
                        </Face>
                        <Face id="310" plane="0 -1 0 -7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="311" plane="-1 0 0 8.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1753" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="247" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.86685 -6.57839 2.5" />
                            <Vertex pos="4.86685 -4.57839 2.5" />
                            <Vertex pos="4.86685 -4.57839 -3.5" />
                            <Vertex pos="4.86685 -6.57839 -3.5" />
                            <Vertex pos="0.86685 -6.57839 2.5" />
                            <Vertex pos="0.86685 -6.57839 -3.5" />
                            <Vertex pos="0.86685 -4.57839 2.5" />
                            <Vertex pos="0.86685 -4.57839 -3.5" />
                        </Vertices>
                        <Face id="240" plane="1 0 0 -4.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="241" plane="-0 -1 -0 -6.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="242" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="243" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 7 5" />
                        </Face>
                        <Face id="244" plane="0 1 -0 4.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="245" plane="-1 -0 -0 0.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1754" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="247" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.13315 -6.57839 -3.5" />
                            <Vertex pos="-1.13315 -4.57839 -3.5" />
                            <Vertex pos="-1.13315 -4.57839 2.5" />
                            <Vertex pos="-1.13315 -6.57839 2.5" />
                            <Vertex pos="0.86685 -6.57839 2.5" />
                            <Vertex pos="0.86685 -6.57839 -3.5" />
                            <Vertex pos="0.86685 -4.57839 2.5" />
                            <Vertex pos="0.86685 -4.57839 -3.5" />
                        </Vertices>
                        <Face id="240" plane="-1 0 0 -1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="241" plane="0 -1 0 -6.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="242" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="243" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 1 0 5" />
                        </Face>
                        <Face id="244" plane="0 1 -0 4.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="245" plane="1 0 0 -0.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1755" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="895" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="22.3668 7.42161 -3.5" />
                            <Vertex pos="22.3668 5.42161 -3.5" />
                            <Vertex pos="22.3668 5.42161 2.5" />
                            <Vertex pos="22.3668 7.42161 2.5" />
                            <Vertex pos="12.3668 5.42161 2.5" />
                            <Vertex pos="12.3668 5.42161 -3.5" />
                            <Vertex pos="12.3668 7.42161 2.5" />
                            <Vertex pos="12.3668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="888" plane="1 0 0 -22.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="889" plane="-0 -1 -0 5.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="890" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="891" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="892" plane="-0 1 0 -7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="893" plane="-1 -0 -0 12.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1756" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="895" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.3668 7.42161 -3.5" />
                            <Vertex pos="8.3668 7.42161 2.5" />
                            <Vertex pos="8.3668 5.42161 2.5" />
                            <Vertex pos="8.3668 5.42161 -3.5" />
                            <Vertex pos="12.3668 5.42161 2.5" />
                            <Vertex pos="12.3668 5.42161 -3.5" />
                            <Vertex pos="12.3668 7.42161 2.5" />
                            <Vertex pos="12.3668 7.42161 -3.5" />
                        </Vertices>
                        <Face id="888" plane="-1 -0 -0 8.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="889" plane="-0 -1 -0 5.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="890" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="891" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="892" plane="-0 1 0 -7.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="893" plane="1 0 0 -12.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1757" owner="0" type="0" pos="2.32453 -5.11063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 2.32453 0 1.3 0 -5.11063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="950" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10.3668 -3.57839 -3.5" />
                            <Vertex pos="10.3668 -5.57839 -3.5" />
                            <Vertex pos="10.3668 -5.57839 2.5" />
                            <Vertex pos="10.3668 -3.57839 2.5" />
                            <Vertex pos="0.36685 -3.57839 -3.5" />
                            <Vertex pos="0.36685 -3.57839 2.5" />
                            <Vertex pos="0.36685 -5.57839 2.5" />
                            <Vertex pos="0.36685 -5.57839 -3.5" />
                        </Vertices>
                        <Face id="943" plane="1 0 0 -10.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="944" plane="0 1 -0 3.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="945" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="946" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 4 7 1" />
                        </Face>
                        <Face id="947" plane="0 -1 0 -5.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="948" plane="-1 0 0 0.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1758" owner="0" type="0" pos="2.32453 -5.11063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 2.32453 0 1.3 0 -5.11063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="950" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.63315 -5.57839 -3.5" />
                            <Vertex pos="-1.63315 -3.57839 -3.5" />
                            <Vertex pos="-1.63315 -3.57839 2.5" />
                            <Vertex pos="-1.63315 -5.57839 2.5" />
                            <Vertex pos="0.36685 -3.57839 -3.5" />
                            <Vertex pos="0.36685 -3.57839 2.5" />
                            <Vertex pos="0.36685 -5.57839 2.5" />
                            <Vertex pos="0.36685 -5.57839 -3.5" />
                        </Vertices>
                        <Face id="943" plane="-1 0 0 -1.63315" album="MyAlbum" material="images (3)" texgens="0 -1 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="944" plane="0 1 -0 3.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="945" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="946" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="947" plane="0 -1 0 -5.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="948" plane="1 -0 0 -0.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1759" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="355" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.8668 -7.57839 -3.5" />
                            <Vertex pos="31.8668 -9.57839 -3.5" />
                            <Vertex pos="31.8668 -9.57839 2.5" />
                            <Vertex pos="31.8668 -7.57839 2.5" />
                            <Vertex pos="7.86685 -7.57839 2.5" />
                            <Vertex pos="7.86685 -7.57839 -3.5" />
                            <Vertex pos="7.86685 -9.57839 2.5" />
                            <Vertex pos="7.86685 -9.57839 -3.5" />
                        </Vertices>
                        <Face id="348" plane="1 0 0 -31.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="349" plane="-0 1 0 7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 5 0" />
                        </Face>
                        <Face id="350" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="351" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="352" plane="0 -1 0 -9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="353" plane="-1 0 0 7.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1761" owner="0" type="0" pos="3.62453 -15.5106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 3.62453 0 1.3 0 -15.5106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="451" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="5.36685 -9.57836 2.5" />
                            <Vertex pos="5.36685 -7.57836 2.5" />
                            <Vertex pos="5.36685 -7.57836 -3.5" />
                            <Vertex pos="5.36685 -9.57836 -3.5" />
                            <Vertex pos="-0.63315 -7.57836 -3.5" />
                            <Vertex pos="-0.63315 -7.57836 2.5" />
                            <Vertex pos="-0.63315 -9.57836 2.5" />
                            <Vertex pos="-0.63315 -9.57836 -3.5" />
                        </Vertices>
                        <Face id="444" plane="1 0 0 -5.36685" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="445" plane="0 1 -0 7.57836" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="446" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="447" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="448" plane="-0 -1 -0 -9.57836" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="449" plane="-1 0 0 -0.63315" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1765" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-26.6332 -25.5784 -3.5" />
                            <Vertex pos="-26.6332 -25.5784 2.5" />
                            <Vertex pos="-28.6332 -25.5784 2.5" />
                            <Vertex pos="-28.6332 -25.5784 -3.5" />
                            <Vertex pos="-28.6332 -29.5784 2.5" />
                            <Vertex pos="-28.6332 -29.5784 -3.5" />
                            <Vertex pos="-26.6332 -29.5784 2.5" />
                            <Vertex pos="-26.6332 -29.5784 -3.5" />
                        </Vertices>
                        <Face id="456" plane="0 1 0 25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="-1 0 0 -28.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="458" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="459" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="460" plane="1 0 0 26.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="461" plane="0 -1 0 -29.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1766" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="463" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-28.6332 -39.5784 2.5" />
                            <Vertex pos="-26.6332 -39.5784 2.5" />
                            <Vertex pos="-26.6332 -39.5784 -3.5" />
                            <Vertex pos="-28.6332 -39.5784 -3.5" />
                            <Vertex pos="-28.6332 -29.5784 2.5" />
                            <Vertex pos="-28.6332 -29.5784 -3.5" />
                            <Vertex pos="-26.6332 -29.5784 2.5" />
                            <Vertex pos="-26.6332 -29.5784 -3.5" />
                        </Vertices>
                        <Face id="456" plane="-0 -1 -0 -39.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="457" plane="-1 0 0 -28.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="458" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="459" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 3 2 7" />
                        </Face>
                        <Face id="460" plane="1 0 0 26.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="461" plane="0 1 0 29.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1767" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="493" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 -25.5784 -3.5" />
                            <Vertex pos="-30.6332 -25.5784 2.5" />
                            <Vertex pos="-32.6332 -25.5784 2.5" />
                            <Vertex pos="-32.6332 -25.5784 -3.5" />
                            <Vertex pos="-32.6332 -29.5784 -3.5" />
                            <Vertex pos="-32.6332 -29.5784 2.5" />
                            <Vertex pos="-30.6332 -29.5784 2.5" />
                            <Vertex pos="-30.6332 -29.5784 -3.5" />
                        </Vertices>
                        <Face id="486" plane="0 1 0 25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="487" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="488" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="489" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="490" plane="1 0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="491" plane="0 -1 0 -29.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1768" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="493" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30.6332 -39.5784 -3.5" />
                            <Vertex pos="-32.6332 -39.5784 -3.5" />
                            <Vertex pos="-32.6332 -39.5784 2.5" />
                            <Vertex pos="-30.6332 -39.5784 2.5" />
                            <Vertex pos="-32.6332 -29.5784 -3.5" />
                            <Vertex pos="-32.6332 -29.5784 2.5" />
                            <Vertex pos="-30.6332 -29.5784 2.5" />
                            <Vertex pos="-30.6332 -29.5784 -3.5" />
                        </Vertices>
                        <Face id="486" plane="0 -1 0 -39.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="487" plane="-1 0 0 -32.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="488" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="489" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="490" plane="1 -0 0 30.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="491" plane="0 1 0 29.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1769" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="457" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 -25.5784 -3.5" />
                            <Vertex pos="33.3668 -25.5784 -3.5" />
                            <Vertex pos="33.3668 -25.5784 2.5" />
                            <Vertex pos="31.3668 -25.5784 2.5" />
                            <Vertex pos="33.3668 -29.5784 2.5" />
                            <Vertex pos="33.3668 -29.5784 -3.5" />
                            <Vertex pos="31.3668 -29.5784 2.5" />
                            <Vertex pos="31.3668 -29.5784 -3.5" />
                        </Vertices>
                        <Face id="450" plane="0 1 -0 25.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="451" plane="1 0 0 -33.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="452" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="453" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="454" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="455" plane="0 -1 0 -29.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1770" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="457" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 -37.5784 -3.5" />
                            <Vertex pos="31.3668 -37.5784 2.5" />
                            <Vertex pos="33.3668 -37.5784 2.5" />
                            <Vertex pos="33.3668 -37.5784 -3.5" />
                            <Vertex pos="33.3668 -29.5784 2.5" />
                            <Vertex pos="33.3668 -29.5784 -3.5" />
                            <Vertex pos="31.3668 -29.5784 2.5" />
                            <Vertex pos="31.3668 -29.5784 -3.5" />
                        </Vertices>
                        <Face id="450" plane="0 -1 0 -37.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="451" plane="1 0 0 -33.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="452" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="453" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="454" plane="-1 0 0 31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="455" plane="0 1 -0 29.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1771" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="289" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-19.1332 -24.5784 -3.5" />
                            <Vertex pos="-19.1332 -24.5784 2.5" />
                            <Vertex pos="-21.1332 -24.5784 2.5" />
                            <Vertex pos="-21.1332 -24.5784 -3.5" />
                            <Vertex pos="-21.1332 -28.5784 2.5" />
                            <Vertex pos="-21.1332 -28.5784 -3.5" />
                            <Vertex pos="-19.1332 -28.5784 2.5" />
                            <Vertex pos="-19.1332 -28.5784 -3.5" />
                        </Vertices>
                        <Face id="282" plane="0 1 0 24.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="283" plane="-1 0 0 -21.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="284" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="285" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="286" plane="1 0 0 19.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="287" plane="0 -1 0 -28.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1772" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="289" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-19.1332 -30.5784 -3.5" />
                            <Vertex pos="-21.1332 -30.5784 -3.5" />
                            <Vertex pos="-21.1332 -30.5784 2.5" />
                            <Vertex pos="-19.1332 -30.5784 2.5" />
                            <Vertex pos="-21.1332 -28.5784 2.5" />
                            <Vertex pos="-21.1332 -28.5784 -3.5" />
                            <Vertex pos="-19.1332 -28.5784 2.5" />
                            <Vertex pos="-19.1332 -28.5784 -3.5" />
                        </Vertices>
                        <Face id="282" plane="0 -1 0 -30.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="283" plane="-1 0 0 -21.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="284" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="285" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 5 1" />
                        </Face>
                        <Face id="286" plane="1 0 0 19.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="287" plane="0 1 0 28.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1773" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-15.1332 -17.5784 -3.5" />
                            <Vertex pos="-15.1332 -17.5784 2.5" />
                            <Vertex pos="-17.1332 -17.5784 2.5" />
                            <Vertex pos="-17.1332 -17.5784 -3.5" />
                            <Vertex pos="-17.1332 -21.5784 2.5" />
                            <Vertex pos="-17.1332 -21.5784 -3.5" />
                            <Vertex pos="-15.1332 -21.5784 2.5" />
                            <Vertex pos="-15.1332 -21.5784 -3.5" />
                        </Vertices>
                        <Face id="384" plane="0 1 0 17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="385" plane="-1 0 0 -17.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="386" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="387" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="388" plane="1 0 0 15.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="389" plane="0 -1 0 -21.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1774" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="391" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-15.1332 -27.5784 -3.5" />
                            <Vertex pos="-17.1332 -27.5784 -3.5" />
                            <Vertex pos="-17.1332 -27.5784 2.5" />
                            <Vertex pos="-15.1332 -27.5784 2.5" />
                            <Vertex pos="-17.1332 -21.5784 2.5" />
                            <Vertex pos="-17.1332 -21.5784 -3.5" />
                            <Vertex pos="-15.1332 -21.5784 2.5" />
                            <Vertex pos="-15.1332 -21.5784 -3.5" />
                        </Vertices>
                        <Face id="384" plane="0 -1 0 -27.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="385" plane="-1 0 0 -17.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="386" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="387" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 5 1" />
                        </Face>
                        <Face id="388" plane="1 0 0 15.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="389" plane="0 1 0 21.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1775" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="331" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10.8668 -17.5784 -3.5" />
                            <Vertex pos="10.8668 -17.5784 2.5" />
                            <Vertex pos="8.86685 -17.5784 2.5" />
                            <Vertex pos="8.86685 -17.5784 -3.5" />
                            <Vertex pos="10.8668 -21.5784 -3.5" />
                            <Vertex pos="10.8668 -21.5784 2.5" />
                            <Vertex pos="8.86685 -21.5784 2.5" />
                            <Vertex pos="8.86685 -21.5784 -3.5" />
                        </Vertices>
                        <Face id="324" plane="0 1 0 17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="325" plane="1 0 0 -10.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="326" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 5 6" />
                        </Face>
                        <Face id="327" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 7" />
                        </Face>
                        <Face id="328" plane="-1 -0 -0 8.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="329" plane="0 -1 0 -21.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1778" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="727" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.17161 2.42161 2.5" />
                            <Vertex pos="-7.17546 0.42161 2.5" />
                            <Vertex pos="-7.17546 0.42161 -3.5" />
                            <Vertex pos="-7.17161 2.42161 -3.5" />
                            <Vertex pos="-3.13315 0.42161 2.5" />
                            <Vertex pos="-3.13315 0.42161 -3.5" />
                            <Vertex pos="-3.13315 2.42161 2.5" />
                            <Vertex pos="-3.13315 2.42161 -3.5" />
                        </Vertices>
                        <Face id="720" plane="-0.999998 0.00192499 0 -7.17626" album="MyAlbum" material="images (3)" texgens="0.00192307 0.999998 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="721" plane="-0 -1 -0 0.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="722" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="723" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 7 3" />
                        </Face>
                        <Face id="724" plane="0 1 -0 -2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="725" plane="1 0 0 3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1780" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="307" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-15.1332 5.42161 -3.5" />
                            <Vertex pos="-15.1332 7.42161 -3.5" />
                            <Vertex pos="-15.1332 7.42161 2.5" />
                            <Vertex pos="-15.1332 5.42161 2.5" />
                            <Vertex pos="-13.1332 7.42161 2.5" />
                            <Vertex pos="-13.1332 7.42161 -3.5" />
                            <Vertex pos="-13.1332 5.42161 2.5" />
                            <Vertex pos="-13.1332 5.42161 -3.5" />
                        </Vertices>
                        <Face id="300" plane="-1 0 0 -15.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="301" plane="-0 1 0 -7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="302" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="303" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="304" plane="0 -1 0 5.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="305" plane="1 -0 0 13.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1782" owner="0" type="0" pos="-11.3255 0.089368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 0.089368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1009" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-19.1332 -1.57839 -3.5" />
                            <Vertex pos="-19.1332 0.42161 -3.5" />
                            <Vertex pos="-19.1332 0.42161 2.5" />
                            <Vertex pos="-19.1332 -1.57839 2.5" />
                            <Vertex pos="-3.13315 0.42161 -3.5" />
                            <Vertex pos="-3.13315 0.42161 2.5" />
                            <Vertex pos="-3.13315 -1.57839 2.5" />
                            <Vertex pos="-3.13315 -1.57839 -3.5" />
                        </Vertices>
                        <Face id="1002" plane="-1 0 0 -19.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1003" plane="0 1 -0 -0.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1004" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="1005" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="1006" plane="0 -1 0 -1.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="1007" plane="1 -0 0 3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1784" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="367" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-17.1332 2.42161 2.5" />
                            <Vertex pos="-17.1332 0.42161 2.5" />
                            <Vertex pos="-17.1332 0.42161 -3.5" />
                            <Vertex pos="-17.1332 2.42161 -3.5" />
                            <Vertex pos="-5.13315 2.42161 2.5" />
                            <Vertex pos="-5.13315 2.42161 -3.5" />
                            <Vertex pos="-5.13315 0.42161 2.5" />
                            <Vertex pos="-5.13315 0.42161 -3.5" />
                        </Vertices>
                        <Face id="360" plane="-1 0 0 -17.1332" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="361" plane="-0 1 0 -2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="362" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="363" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 3 2 7" />
                        </Face>
                        <Face id="364" plane="0 -1 0 0.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="365" plane="1 -0 0 5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1786" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="307" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-19.1332 -8.57839 2.5" />
                            <Vertex pos="-19.1332 -10.5784 2.5" />
                            <Vertex pos="-19.1332 -10.5784 -3.5" />
                            <Vertex pos="-19.1332 -8.57839 -3.5" />
                            <Vertex pos="-13.1332 -10.5784 -3.5" />
                            <Vertex pos="-13.1332 -10.5784 2.5" />
                            <Vertex pos="-13.1332 -8.57839 2.5" />
                            <Vertex pos="-13.1332 -8.57839 -3.5" />
                        </Vertices>
                        <Face id="300" plane="-1 0 0 -19.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="301" plane="0 -1 0 -10.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="302" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 6 5" />
                        </Face>
                        <Face id="303" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="304" plane="-0 1 0 8.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="305" plane="1 0 0 13.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1788" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="475" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-26.6332 -37.5784 -3.5" />
                            <Vertex pos="-26.6332 -37.5784 2.5" />
                            <Vertex pos="-26.6332 -39.5784 2.5" />
                            <Vertex pos="-26.6332 -39.5784 -3.5" />
                            <Vertex pos="-12.6332 -39.5784 2.5" />
                            <Vertex pos="-12.6332 -39.5784 -3.5" />
                            <Vertex pos="-12.6332 -37.5784 2.5" />
                            <Vertex pos="-12.6332 -37.5784 -3.5" />
                        </Vertices>
                        <Face id="468" plane="-1 -0 -0 -26.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="469" plane="-0 -1 -0 -39.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="470" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="471" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="472" plane="0 1 -0 37.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="473" plane="1 0 0 12.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1790" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="319" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.13315 -7.57839 -3.5" />
                            <Vertex pos="-9.13315 -5.57839 -3.5" />
                            <Vertex pos="-9.13315 -5.57839 2.5" />
                            <Vertex pos="-9.13315 -7.57839 2.5" />
                            <Vertex pos="-5.13315 -5.57839 2.5" />
                            <Vertex pos="-5.13315 -5.57839 -3.5" />
                            <Vertex pos="-5.13315 -7.57839 2.5" />
                            <Vertex pos="-5.13315 -7.57839 -3.5" />
                        </Vertices>
                        <Face id="312" plane="-1 0 0 -9.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="313" plane="-0 1 0 5.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="314" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="315" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="316" plane="0 -1 0 -7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="317" plane="1 -0 0 5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1792" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="331" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.13315 -19.5784 -3.5" />
                            <Vertex pos="-9.13315 -17.5784 -3.5" />
                            <Vertex pos="-9.13315 -17.5784 2.5" />
                            <Vertex pos="-9.13315 -19.5784 2.5" />
                            <Vertex pos="-5.13315 -19.5784 2.5" />
                            <Vertex pos="-5.13315 -19.5784 -3.5" />
                            <Vertex pos="-5.13315 -17.5784 2.5" />
                            <Vertex pos="-5.13315 -17.5784 -3.5" />
                        </Vertices>
                        <Face id="324" plane="-1 0 0 -9.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="325" plane="0 -1 0 -19.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="326" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 6 4" />
                        </Face>
                        <Face id="327" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 5 7 1" />
                        </Face>
                        <Face id="328" plane="-0 1 0 17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="329" plane="1 0 0 5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1794" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-7.13315 -21.5784 2.5" />
                            <Vertex pos="-7.13315 -23.5784 2.5" />
                            <Vertex pos="-7.13315 -23.5784 -3.5" />
                            <Vertex pos="-7.13315 -21.5784 -3.5" />
                            <Vertex pos="-5.13315 -23.5784 2.5" />
                            <Vertex pos="-5.13315 -23.5784 -3.5" />
                            <Vertex pos="-5.13315 -21.5784 2.5" />
                            <Vertex pos="-5.13315 -21.5784 -3.5" />
                        </Vertices>
                        <Face id="330" plane="-1 0 0 -7.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="331" plane="-0 -1 -0 -23.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="332" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="333" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 7 3" />
                        </Face>
                        <Face id="334" plane="0 1 -0 21.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="335" plane="1 0 0 5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1795" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="884" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.3668 5.42161 -3.5" />
                            <Vertex pos="2.3668 3.42161 -3.5" />
                            <Vertex pos="2.3668 3.42161 2.5" />
                            <Vertex pos="2.3668 5.42161 2.5" />
                            <Vertex pos="0.3668 3.42161 2.5" />
                            <Vertex pos="0.3668 3.42161 -3.5" />
                            <Vertex pos="0.3668 5.42161 2.5" />
                            <Vertex pos="0.3668 5.42161 -3.5" />
                        </Vertices>
                        <Face id="877" plane="1 0 0 -2.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="878" plane="-0 -1 -0 3.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="879" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="880" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="881" plane="0 1 -0 -5.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="882" plane="-1 -0 -0 0.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1796" owner="0" type="0" pos="-13.2755 9.18937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -13.2755 0 1.3 0 9.18937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="884" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.6332 5.42161 -3.5" />
                            <Vertex pos="-1.6332 5.42161 2.5" />
                            <Vertex pos="-1.6332 3.42161 2.5" />
                            <Vertex pos="-1.6332 3.42161 -3.5" />
                            <Vertex pos="0.3668 3.42161 2.5" />
                            <Vertex pos="0.3668 3.42161 -3.5" />
                            <Vertex pos="0.3668 5.42161 2.5" />
                            <Vertex pos="0.3668 5.42161 -3.5" />
                        </Vertices>
                        <Face id="877" plane="-1 -0 -0 -1.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="878" plane="-0 -1 -0 3.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="879" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="880" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 80 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="881" plane="0 1 -0 -5.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="882" plane="1 0 0 -0.3668" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1797" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="361" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="7.86685 -9.57839 -3.5" />
                            <Vertex pos="7.86685 -9.57839 2.5" />
                            <Vertex pos="7.86685 -7.57839 2.5" />
                            <Vertex pos="7.86685 -7.57839 -3.5" />
                            <Vertex pos="-4.13315 -7.57839 2.5" />
                            <Vertex pos="-4.13315 -7.57839 -3.5" />
                            <Vertex pos="-4.13315 -9.57839 2.5" />
                            <Vertex pos="-4.13315 -9.57839 -3.5" />
                        </Vertices>
                        <Face id="354" plane="1 -0 0 -7.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="355" plane="-0 1 0 7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="356" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="357" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="358" plane="0 -1 0 -9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="359" plane="-1 0 0 -4.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1798" owner="0" type="0" pos="-7.42547 -10.3106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -7.42547 0 1.3 0 -10.3106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="361" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6.13315 -9.57839 -3.5" />
                            <Vertex pos="-6.13315 -7.57839 -3.5" />
                            <Vertex pos="-6.13315 -7.57839 2.5" />
                            <Vertex pos="-6.13315 -9.57839 2.5" />
                            <Vertex pos="-4.13315 -7.57839 2.5" />
                            <Vertex pos="-4.13315 -7.57839 -3.5" />
                            <Vertex pos="-4.13315 -9.57839 2.5" />
                            <Vertex pos="-4.13315 -9.57839 -3.5" />
                        </Vertices>
                        <Face id="354" plane="-1 0 0 -6.13315" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="355" plane="-0 1 0 7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="356" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="357" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="358" plane="0 -1 0 -9.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="359" plane="1 -0 0 4.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1799" owner="0" type="0" pos="3.62453 -15.5106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 3.62453 0 1.3 0 -15.5106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="457" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.63315 -9.57836 -3.5" />
                            <Vertex pos="-0.63315 -9.57836 2.5" />
                            <Vertex pos="-0.63315 -7.57836 2.5" />
                            <Vertex pos="-0.63315 -7.57836 -3.5" />
                            <Vertex pos="-12.6332 -7.57836 -3.5" />
                            <Vertex pos="-12.6332 -7.57836 2.5" />
                            <Vertex pos="-12.6332 -9.57836 2.5" />
                            <Vertex pos="-12.6332 -9.57836 -3.5" />
                        </Vertices>
                        <Face id="450" plane="1 -0 0 0.63315" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="451" plane="0 1 -0 7.57836" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="452" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="453" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 4 7 0" />
                        </Face>
                        <Face id="454" plane="-0 -1 -0 -9.57836" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="455" plane="-1 0 0 -12.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1800" owner="0" type="0" pos="3.62453 -15.5106 8" rot="1 0 0 0" scale="" transform="1.3 0 0 3.62453 0 1.3 0 -15.5106 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="457" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-14.6332 -9.57836 -3.5" />
                            <Vertex pos="-14.6332 -7.57836 -3.5" />
                            <Vertex pos="-14.6332 -7.57836 2.5" />
                            <Vertex pos="-14.6332 -9.57836 2.5" />
                            <Vertex pos="-12.6332 -7.57836 -3.5" />
                            <Vertex pos="-12.6332 -7.57836 2.5" />
                            <Vertex pos="-12.6332 -9.57836 2.5" />
                            <Vertex pos="-12.6332 -9.57836 -3.5" />
                        </Vertices>
                        <Face id="450" plane="-1 0 0 -14.6332" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="451" plane="0 1 -0 7.57836" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="452" plane="-0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="453" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="454" plane="-0 -1 -0 -9.57836" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="455" plane="1 -0 0 12.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1801" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="733" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.86685 0.42161 -3.5" />
                            <Vertex pos="0.86685 0.42161 2.5" />
                            <Vertex pos="0.86685 2.42161 2.5" />
                            <Vertex pos="0.86685 2.42161 -3.5" />
                            <Vertex pos="-1.13315 0.42161 2.5" />
                            <Vertex pos="-1.13315 0.42161 -3.5" />
                            <Vertex pos="-1.13315 2.42161 2.5" />
                            <Vertex pos="-1.13315 2.42161 -3.5" />
                        </Vertices>
                        <Face id="726" plane="1 -0 0 -0.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="727" plane="-0 -1 -0 0.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 5" />
                        </Face>
                        <Face id="728" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 1 4 6" />
                        </Face>
                        <Face id="729" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 0 3 7" />
                        </Face>
                        <Face id="730" plane="0 1 -0 -2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="731" plane="-1 -0 -0 -1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1802" owner="0" type="0" pos="-11.3255 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="733" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.13315 2.42161 -3.5" />
                            <Vertex pos="-3.13315 2.42161 2.5" />
                            <Vertex pos="-3.13315 0.42161 2.5" />
                            <Vertex pos="-3.13315 0.42161 -3.5" />
                            <Vertex pos="-1.13315 0.42161 2.5" />
                            <Vertex pos="-1.13315 0.42161 -3.5" />
                            <Vertex pos="-1.13315 2.42161 2.5" />
                            <Vertex pos="-1.13315 2.42161 -3.5" />
                        </Vertices>
                        <Face id="726" plane="-1 -0 -0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="727" plane="-0 -1 -0 0.42161" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="728" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="729" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="730" plane="0 1 -0 -2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="731" plane="1 0 0 1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 128 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1803" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="313" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5.13315 5.42161 -3.5" />
                            <Vertex pos="-5.13315 5.42161 2.5" />
                            <Vertex pos="-5.13315 7.42161 2.5" />
                            <Vertex pos="-5.13315 7.42161 -3.5" />
                            <Vertex pos="-11.1332 7.42161 2.5" />
                            <Vertex pos="-11.1332 7.42161 -3.5" />
                            <Vertex pos="-11.1332 5.42161 2.5" />
                            <Vertex pos="-11.1332 5.42161 -3.5" />
                        </Vertices>
                        <Face id="306" plane="1 -0 0 5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="307" plane="-0 1 0 -7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="308" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="309" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="310" plane="0 -1 0 5.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="311" plane="-1 0 0 -11.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1804" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="313" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-13.1332 5.42161 -3.5" />
                            <Vertex pos="-13.1332 7.42161 -3.5" />
                            <Vertex pos="-13.1332 7.42161 2.5" />
                            <Vertex pos="-13.1332 5.42161 2.5" />
                            <Vertex pos="-11.1332 7.42161 2.5" />
                            <Vertex pos="-11.1332 7.42161 -3.5" />
                            <Vertex pos="-11.1332 5.42161 2.5" />
                            <Vertex pos="-11.1332 5.42161 -3.5" />
                        </Vertices>
                        <Face id="306" plane="-1 0 0 -13.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="307" plane="-0 1 0 -7.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="308" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="309" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="310" plane="0 -1 0 5.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="311" plane="1 -0 0 11.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1805" owner="0" type="0" pos="-11.3255 0.089368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 0.089368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1015" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="4.86685 -1.57839 2.5" />
                            <Vertex pos="4.86685 0.42161 2.5" />
                            <Vertex pos="4.86685 0.42161 -3.5" />
                            <Vertex pos="4.86685 -1.57839 -3.5" />
                            <Vertex pos="-1.13315 0.42161 -3.5" />
                            <Vertex pos="-1.13315 0.42161 2.5" />
                            <Vertex pos="-1.13315 -1.57839 2.5" />
                            <Vertex pos="-1.13315 -1.57839 -3.5" />
                        </Vertices>
                        <Face id="1008" plane="1 0 0 -4.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1009" plane="0 1 -0 -0.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="1010" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="1011" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="1012" plane="0 -1 0 -1.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="1013" plane="-1 0 0 -1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1806" owner="0" type="0" pos="-11.3255 0.089368 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -11.3255 0 1.3 0 0.089368 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="1015" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.13315 -1.57839 -3.5" />
                            <Vertex pos="-3.13315 0.42161 -3.5" />
                            <Vertex pos="-3.13315 0.42161 2.5" />
                            <Vertex pos="-3.13315 -1.57839 2.5" />
                            <Vertex pos="-1.13315 0.42161 -3.5" />
                            <Vertex pos="-1.13315 0.42161 2.5" />
                            <Vertex pos="-1.13315 -1.57839 2.5" />
                            <Vertex pos="-1.13315 -1.57839 -3.5" />
                        </Vertices>
                        <Face id="1008" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1009" plane="0 1 -0 -0.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1010" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 5 6 3" />
                        </Face>
                        <Face id="1011" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 192 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="1012" plane="0 -1 0 -1.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="1013" plane="1 -0 0 1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 192 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1807" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="373" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.13315 2.42161 -3.5" />
                            <Vertex pos="-1.13315 0.42161 -3.5" />
                            <Vertex pos="-1.13315 0.42161 2.5" />
                            <Vertex pos="-1.13315 2.42161 2.5" />
                            <Vertex pos="-3.13315 2.42161 2.5" />
                            <Vertex pos="-3.13315 2.42161 -3.5" />
                            <Vertex pos="-3.13315 0.42161 2.5" />
                            <Vertex pos="-3.13315 0.42161 -3.5" />
                        </Vertices>
                        <Face id="366" plane="1 0 0 1.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="367" plane="0 1 0 -2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 4 5" />
                        </Face>
                        <Face id="368" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 6" />
                        </Face>
                        <Face id="369" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 5 7" />
                        </Face>
                        <Face id="370" plane="0 -1 0 0.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 7 6 2" />
                        </Face>
                        <Face id="371" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1808" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="373" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5.13315 0.42161 -3.5" />
                            <Vertex pos="-5.13315 2.42161 -3.5" />
                            <Vertex pos="-5.13315 2.42161 2.5" />
                            <Vertex pos="-5.13315 0.42161 2.5" />
                            <Vertex pos="-3.13315 2.42161 2.5" />
                            <Vertex pos="-3.13315 2.42161 -3.5" />
                            <Vertex pos="-3.13315 0.42161 2.5" />
                            <Vertex pos="-3.13315 0.42161 -3.5" />
                        </Vertices>
                        <Face id="366" plane="-1 0 0 -5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="367" plane="-0 1 0 -2.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="368" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="369" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="370" plane="0 -1 0 0.42161" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="371" plane="1 -0 0 3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1809" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="313" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.13315 -8.57839 -3.5" />
                            <Vertex pos="-3.13315 -10.5784 -3.5" />
                            <Vertex pos="-3.13315 -10.5784 2.5" />
                            <Vertex pos="-3.13315 -8.57839 2.5" />
                            <Vertex pos="-11.1332 -10.5784 -3.5" />
                            <Vertex pos="-11.1332 -10.5784 2.5" />
                            <Vertex pos="-11.1332 -8.57839 2.5" />
                            <Vertex pos="-11.1332 -8.57839 -3.5" />
                        </Vertices>
                        <Face id="306" plane="1 0 0 3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="307" plane="0 -1 0 -10.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="308" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 5" />
                        </Face>
                        <Face id="309" plane="-0 -0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 0 7 4" />
                        </Face>
                        <Face id="310" plane="0 1 0 8.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="311" plane="-1 -0 -0 -11.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="1810" owner="0" type="0" pos="1.67453 1.38937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.67453 0 1.3 0 1.38937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="313" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-13.1332 -8.57839 -3.5" />
                            <Vertex pos="-13.1332 -8.57839 2.5" />
                            <Vertex pos="-13.1332 -10.5784 2.5" />
                            <Vertex pos="-13.1332 -10.5784 -3.5" />
                            <Vertex pos="-11.1332 -10.5784 -3.5" />
                            <Vertex pos="-11.1332 -10.5784 2.5" />
                            <Vertex pos="-11.1332 -8.57839 2.5" />
                            <Vertex pos="-11.1332 -8.57839 -3.5" />
                        </Vertices>
                        <Face id="306" plane="-1 -0 -0 -13.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="307" plane="0 -1 0 -10.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="308" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 5 2" />
                        </Face>
                        <Face id="309" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="310" plane="-0 1 0 8.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="311" plane="1 0 0 11.1332" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="1811" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="481" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="31.3668 -37.5784 -3.5" />
                            <Vertex pos="31.3668 -39.5784 -3.5" />
                            <Vertex pos="31.3668 -39.5784 2.5" />
                            <Vertex pos="31.3668 -37.5784 2.5" />
                            <Vertex pos="-10.6332 -39.5784 2.5" />
                            <Vertex pos="-10.6332 -39.5784 -3.5" />
                            <Vertex pos="-10.6332 -37.5784 2.5" />
                            <Vertex pos="-10.6332 -37.5784 -3.5" />
                        </Vertices>
                        <Face id="474" plane="1 0 0 -31.3668" album="MyAlbum" material="images (3)" texgens="0 -1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="475" plane="-0 -1 -0 -39.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="476" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="477" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 5 1" />
                        </Face>
                        <Face id="478" plane="0 1 -0 37.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="479" plane="-1 -0 -0 -10.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1812" owner="0" type="0" pos="1.02453 2.68937 8" rot="1 0 0 0" scale="" transform="1.3 0 0 1.02453 0 1.3 0 2.68937 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="481" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12.6332 -33.5784 -3.5" />
                            <Vertex pos="-12.6332 -33.5784 2.5" />
                            <Vertex pos="-12.6332 -39.5784 2.5" />
                            <Vertex pos="-12.6332 -39.5784 -3.5" />
                            <Vertex pos="-10.6332 -39.5784 2.5" />
                            <Vertex pos="-10.6332 -39.5784 -3.5" />
                            <Vertex pos="-10.6332 -33.5784 2.5" />
                            <Vertex pos="-10.6332 -33.5784 -3.5" />
                        </Vertices>
                        <Face id="474" plane="-1 -0 -0 -12.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="475" plane="-0 -1 -0 -39.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="476" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="477" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 -1 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 5" />
                        </Face>
                        <Face id="478" plane="0 1 -0 33.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="479" plane="1 0 0 10.6332" album="MyAlbum" material="images (3)" texgens="0 1 0 48 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1813" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="325" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.86685 -7.57839 -3.5" />
                            <Vertex pos="8.86685 -7.57839 2.5" />
                            <Vertex pos="8.86685 -5.57839 2.5" />
                            <Vertex pos="8.86685 -5.57839 -3.5" />
                            <Vertex pos="-3.13315 -5.57839 2.5" />
                            <Vertex pos="-3.13315 -5.57839 -3.5" />
                            <Vertex pos="-3.13315 -7.57839 2.5" />
                            <Vertex pos="-3.13315 -7.57839 -3.5" />
                        </Vertices>
                        <Face id="318" plane="1 -0 0 -8.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="319" plane="-0 1 0 5.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="320" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="321" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="322" plane="0 -1 0 -7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="323" plane="-1 0 0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1814" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="325" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5.13315 -7.57839 -3.5" />
                            <Vertex pos="-5.13315 -5.57839 -3.5" />
                            <Vertex pos="-5.13315 -5.57839 2.5" />
                            <Vertex pos="-5.13315 -7.57839 2.5" />
                            <Vertex pos="-3.13315 -5.57839 2.5" />
                            <Vertex pos="-3.13315 -5.57839 -3.5" />
                            <Vertex pos="-3.13315 -7.57839 2.5" />
                            <Vertex pos="-3.13315 -7.57839 -3.5" />
                        </Vertices>
                        <Face id="318" plane="-1 0 0 -5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="319" plane="-0 1 0 5.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="320" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 6 3" />
                        </Face>
                        <Face id="321" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="322" plane="0 -1 0 -7.57839" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="323" plane="1 -0 0 3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1815" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="8.86685 -17.5784 -3.5" />
                            <Vertex pos="8.86685 -19.5784 -3.5" />
                            <Vertex pos="8.86685 -19.5784 2.5" />
                            <Vertex pos="8.86685 -17.5784 2.5" />
                            <Vertex pos="-3.13315 -19.5784 2.5" />
                            <Vertex pos="-3.13315 -19.5784 -3.5" />
                            <Vertex pos="-3.13315 -17.5784 2.5" />
                            <Vertex pos="-3.13315 -17.5784 -3.5" />
                        </Vertices>
                        <Face id="330" plane="1 0 0 -8.86685" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="331" plane="-0 -1 -0 -19.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="332" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 3 2 4" />
                        </Face>
                        <Face id="333" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="334" plane="-0 1 0 17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 6 7 0" />
                        </Face>
                        <Face id="335" plane="-1 -0 -0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1816" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="337" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5.13315 -17.5784 -3.5" />
                            <Vertex pos="-5.13315 -17.5784 2.5" />
                            <Vertex pos="-5.13315 -19.5784 2.5" />
                            <Vertex pos="-5.13315 -19.5784 -3.5" />
                            <Vertex pos="-3.13315 -19.5784 2.5" />
                            <Vertex pos="-3.13315 -19.5784 -3.5" />
                            <Vertex pos="-3.13315 -17.5784 2.5" />
                            <Vertex pos="-3.13315 -17.5784 -3.5" />
                        </Vertices>
                        <Face id="330" plane="-1 -0 -0 -5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="331" plane="-0 -1 -0 -19.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="332" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 1 6 4 2" />
                        </Face>
                        <Face id="333" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="334" plane="-0 1 0 17.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 16 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="335" plane="1 0 0 3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1817" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="343" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="10.8668 -21.5784 -3.5" />
                            <Vertex pos="10.8668 -23.5784 -3.5" />
                            <Vertex pos="10.8668 -23.5784 2.5" />
                            <Vertex pos="10.8668 -21.5784 2.5" />
                            <Vertex pos="-3.13315 -23.5784 2.5" />
                            <Vertex pos="-3.13315 -23.5784 -3.5" />
                            <Vertex pos="-3.13315 -21.5784 2.5" />
                            <Vertex pos="-3.13315 -21.5784 -3.5" />
                        </Vertices>
                        <Face id="336" plane="1 0 0 -10.8668" album="MyAlbum" material="images (3)" texgens="0 -1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="337" plane="-0 -1 -0 -23.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="338" plane="0 -0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="339" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="340" plane="0 1 -0 21.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="341" plane="-1 -0 -0 -3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1818" owner="0" type="0" pos="-8.72547 -7.71063 8" rot="1 0 0 0" scale="" transform="1.3 0 0 -8.72547 0 1.3 0 -7.71063 0 0 2 8 0 0 0 1" group="-1" locked="0" nextFaceID="343" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5.13315 -21.5784 -3.5" />
                            <Vertex pos="-5.13315 -21.5784 2.5" />
                            <Vertex pos="-5.13315 -23.5784 2.5" />
                            <Vertex pos="-5.13315 -23.5784 -3.5" />
                            <Vertex pos="-3.13315 -23.5784 2.5" />
                            <Vertex pos="-3.13315 -23.5784 -3.5" />
                            <Vertex pos="-3.13315 -21.5784 2.5" />
                            <Vertex pos="-3.13315 -21.5784 -3.5" />
                        </Vertices>
                        <Face id="336" plane="-1 -0 -0 -5.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="337" plane="-0 -1 -0 -23.5784" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 2 4 5 3" />
                        </Face>
                        <Face id="338" plane="0 0 1 -2.5" album="MyAlbum" material="images (3)" texgens="1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 4 2 1 6" />
                        </Face>
                        <Face id="339" plane="0 0 -1 -3.5" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 -1 0 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 5 7 0" />
                        </Face>
                        <Face id="340" plane="0 1 -0 21.5784" album="MyAlbum" material="images (3)" texgens="-1 0 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 0 7 6 1" />
                        </Face>
                        <Face id="341" plane="1 0 0 3.13315" album="MyAlbum" material="images (3)" texgens="0 1 0 32 0 0 1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="1819" owner="0" type="0" pos="1.67453 -4.46063 0.5" rot="1 0 0 0" scale="" transform="2.6 0 0 1.67453 0 2.6 0 -4.46063 0 0 1 0.5 0 0 0 1" group="-1" locked="0" nextFaceID="6085" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="16.5 17 0.5" />
                            <Vertex pos="16.5 17 -0.5" />
                            <Vertex pos="16.5 -17 0.5" />
                            <Vertex pos="16.5 -17 -0.5" />
                            <Vertex pos="-16.5 17 0.5" />
                            <Vertex pos="-16.5 17 -0.5" />
                            <Vertex pos="-16.5 -17 0.5" />
                            <Vertex pos="-16.5 -17 -0.5" />
                        </Vertices>
                        <Face id="6078" plane="1 -0 0 -16.5" album="MyAlbum" material="images (4)" texgens="0 1 0 544 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="6079" plane="-1 0 0 -16.5" album="MyAlbum" material="images (4)" texgens="0 -1 0 544 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="6080" plane="0 1 -0 -17" album="MyAlbum" material="images (4)" texgens="-1 0 0 528 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="6081" plane="0 -1 0 -17" album="MyAlbum" material="images (4)" texgens="1 0 0 528 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="6082" plane="-0 0 1 -0.5" album="MyAlbum" material="images (4)" texgens="1 0 0 528 0 -1 0 -544 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="6083" plane="0 0 -1 -0.5" album="MyAlbum" material="images (4)" texgens="-1 0 0 528 0 -1 0 -544 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="1820" owner="0" type="0" pos="1.17453 -4.46063 13.5" rot="1 0 0 0" scale="" transform="2.6 0 0 1.17453 0 2.6 0 -4.46063 0 0 1 13.5 0 0 0 1" group="-1" locked="0" nextFaceID="6085" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="16.5 17 0.5" />
                            <Vertex pos="16.5 17 -0.5" />
                            <Vertex pos="16.5 -17 0.5" />
                            <Vertex pos="16.5 -17 -0.5" />
                            <Vertex pos="-16.5 17 0.5" />
                            <Vertex pos="-16.5 17 -0.5" />
                            <Vertex pos="-16.5 -17 0.5" />
                            <Vertex pos="-16.5 -17 -0.5" />
                        </Vertices>
                        <Face id="6078" plane="1 -0 0 -16.5" album="MyAlbum" material="images (4)" texgens="0 1 0 544 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="6079" plane="-1 0 0 -16.5" album="MyAlbum" material="images (4)" texgens="0 -1 0 544 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="6080" plane="0 1 -0 -17" album="MyAlbum" material="images (4)" texgens="-1 0 0 528 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="6081" plane="0 -1 0 -17" album="MyAlbum" material="images (4)" texgens="1 0 0 528 0 0 -1 -16 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="6082" plane="-0 0 1 -0.5" album="MyAlbum" material="images (4)" texgens="1 0 0 528 0 -1 0 -544 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="6083" plane="0 0 -1 -0.5" album="MyAlbum" material="images (4)" texgens="-1 0 0 528 0 -1 0 -544 0 1 1" texRot="0" texScale="1 1" texDiv="64 64">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
