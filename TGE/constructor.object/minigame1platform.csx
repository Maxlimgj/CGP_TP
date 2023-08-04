<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2015/01/28 15:51:24">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="1" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneShapes nextShapeID="6">
        <SceneShape id="0" type="0" file="TGE/tutorial.base/data/shapes/player/player.dts" pos="-11.5 36.5 10.5" rot="1 0 0 0" scale="1 1 1" transform="1 0 0 -11.5 0 1 0 36.5 0 0 1 10.5 0 0 0 1" group="-1" locked="0" />
    </SceneShapes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="5">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                    <Entity id="3" classname="light_point" gametype="Constructor" isPointEntity="1" origin="3 30 9" direction="0 -0 -0">
                        <Properties color="255 255 255" intensity="100.0" falloff_inner="1.0" falloff_outer="10.0" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="55">
                    <Brush id="5" owner="0" type="0" pos="1 4.5 3.5" rot="-1 0 0 0.331612" scale="" transform="1.02 0 0 1 0 1.81469 -0.447058 4.5 0 0.470876 0.799546 3.5 0 0 0 1" group="-1" locked="0" nextFaceID="1345" nextVertexID="1793">
                        <Vertices>
                            <Vertex pos="1 5 1" />
                            <Vertex pos="1 5 -1" />
                            <Vertex pos="1 -5 1" />
                            <Vertex pos="1 -5 -1" />
                            <Vertex pos="-1 5 1" />
                            <Vertex pos="-1 5 -1" />
                            <Vertex pos="-1 -5 1" />
                            <Vertex pos="-1 -5 -1" />
                        </Vertices>
                        <Face id="1338" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 160 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1339" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="1340" plane="0 1 -0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="1341" plane="0 -1 0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="1342" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="1343" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="1 19 5.5" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 19 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="169" nextVertexID="225">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="162" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="163" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="164" plane="0 1 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="165" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="166" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="167" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="7 19 5.5" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 19 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="169" nextVertexID="225">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="162" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="163" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="164" plane="0 1 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="165" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="166" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="167" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="7 25 5.5" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 25 0 0 1 5.5 0 0 0 1" group="-1" locked="0" nextFaceID="169" nextVertexID="225">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="162" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="163" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="164" plane="0 1 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="165" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="166" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="167" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="7 28 7" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 28 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="169" nextVertexID="225">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="162" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="163" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="164" plane="0 1 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="165" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="166" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="167" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="7 31 8.5" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 31 0 0 1 8.5 0 0 0 1" group="-1" locked="0" nextFaceID="169" nextVertexID="225">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="162" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="163" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="164" plane="0 1 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="165" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="166" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="167" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="7 34 10" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 34 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="169" nextVertexID="225">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="162" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="163" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="164" plane="0 1 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="165" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="166" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="167" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-3 36 10" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 3 0 36 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="169" nextVertexID="225">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="162" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="163" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="164" plane="0 1 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="165" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="166" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="167" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-3 40.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 40.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="73" nextVertexID="63">
                        <Vertices>
                            <Vertex pos="5.00679e-006 -3.8147e-006 -0.999999" />
                            <Vertex pos="0.433012 0.249992 -0.866029" />
                            <Vertex pos="0.499995 1.14441e-005 -0.866028" />
                            <Vertex pos="0.25001 0.432999 -0.866028" />
                            <Vertex pos="-1.00136e-005 0.500004 -0.866026" />
                            <Vertex pos="-0.24999 0.43301 -0.86603" />
                            <Vertex pos="-0.43301 0.25 -0.866028" />
                            <Vertex pos="-0.499998 1.14441e-005 -0.866028" />
                            <Vertex pos="-0.433014 -0.249992 -0.866028" />
                            <Vertex pos="-0.250009 -0.433006 -0.866027" />
                            <Vertex pos="-1.90735e-006 -0.5 -0.866027" />
                            <Vertex pos="0.249998 -0.433014 -0.866026" />
                            <Vertex pos="0.433016 -0.249992 -0.866028" />
                            <Vertex pos="0.749996 0.433022 -0.500003" />
                            <Vertex pos="0.866025 -7.62939e-006 -0.500003" />
                            <Vertex pos="0.433015 0.749985 -0.500012" />
                            <Vertex pos="-1.19209e-006 0.866024 -0.500001" />
                            <Vertex pos="-0.433016 0.75 -0.499999" />
                            <Vertex pos="-0.750001 0.433014 -0.499998" />
                            <Vertex pos="-0.866022 0 -0.500006" />
                            <Vertex pos="-0.75 -0.433018 -0.500001" />
                            <Vertex pos="-0.433013 -0.749996 -0.500009" />
                            <Vertex pos="6.91414e-006 -0.866028 -0.500002" />
                            <Vertex pos="0.433006 -0.749996 -0.500011" />
                            <Vertex pos="0.750005 -0.433006 -0.500001" />
                            <Vertex pos="0.866024 0.5 -2.92063e-006" />
                            <Vertex pos="0.999999 -3.8147e-006 -2.26498e-006" />
                            <Vertex pos="0.5 0.86602 -2.68221e-006" />
                            <Vertex pos="-1.90735e-006 0.999996 -1.78814e-006" />
                            <Vertex pos="-0.5 0.866024 1.03712e-005" />
                            <Vertex pos="-0.866019 0.500004 1.07288e-006" />
                            <Vertex pos="-0.999999 -3.8147e-006 -2.74181e-006" />
                            <Vertex pos="-0.866027 -0.499996 -2.38419e-006" />
                            <Vertex pos="-0.499998 -0.866028 8.70228e-006" />
                            <Vertex pos="-1.90735e-006 -0.999996 -5.06639e-006" />
                            <Vertex pos="0.500005 -0.866016 -7.86781e-006" />
                            <Vertex pos="0.866026 -0.499996 -6.97374e-006" />
                            <Vertex pos="0.749999 0.43301 0.5" />
                            <Vertex pos="0.866026 -3.8147e-006 0.499997" />
                            <Vertex pos="0.433007 0.750004 0.499995" />
                            <Vertex pos="-1.16825e-005 0.866028 0.499993" />
                            <Vertex pos="-0.433012 0.75 0.499996" />
                            <Vertex pos="-0.749995 0.433014 0.500003" />
                            <Vertex pos="-0.866022 0 0.500003" />
                            <Vertex pos="-0.75 -0.433014 0.499998" />
                            <Vertex pos="-0.433018 -0.749992 0.500002" />
                            <Vertex pos="-9.77516e-006 -0.86602 0.499996" />
                            <Vertex pos="0.433016 -0.749992 0.500014" />
                            <Vertex pos="0.750005 -0.433006 0.499996" />
                            <Vertex pos="0.433008 0.250008 0.866025" />
                            <Vertex pos="0.499997 0 0.866026" />
                            <Vertex pos="0.250006 0.433006 0.866023" />
                            <Vertex pos="1.43051e-006 0.499992 0.866026" />
                            <Vertex pos="-0.250002 0.433006 0.866025" />
                            <Vertex pos="-0.433011 0.249996 0.866027" />
                            <Vertex pos="-0.5 3.8147e-006 0.866024" />
                            <Vertex pos="-0.433009 -0.250008 0.866026" />
                            <Vertex pos="-0.250009 -0.43301 0.866023" />
                            <Vertex pos="1.16825e-005 -0.5 0.866025" />
                            <Vertex pos="0.249988 -0.433022 0.866023" />
                            <Vertex pos="0.433011 -0.249996 0.866026" />
                            <Vertex pos="-5.96046e-006 -7.62939e-006 0.999999" />
                        </Vertices>
                        <Face id="0" plane="0.258195 0.0691836 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 4.14121 -0.930778 -0.249401 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0.189012 0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 0.707108 0 4.14116 -0.681377 -0.681377 -0.267303 -8.55392 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 0 1" />
                        </Face>
                        <Face id="2" plane="0.0691877 0.258195 -0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258814 0 4.14116 -0.249397 -0.930779 -0.267303 -8.55395 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3" />
                        </Face>
                        <Face id="3" plane="-0.06918 0.258191 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 0.249405 -0.930777 -0.267304 -8.55394 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 0 4" />
                        </Face>
                        <Face id="4" plane="-0.189008 0.18901 -0.963614 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 4.14093 0.681377 -0.681377 -0.267303 -8.5539 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 5" />
                        </Face>
                        <Face id="5" plane="-0.258189 0.0691859 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 4.141 0.930778 -0.249404 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 0 6" />
                        </Face>
                        <Face id="6" plane="-0.258193 -0.0691777 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258818 -0.965926 0 4.141 0.930778 0.249401 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 8 0 7" />
                        </Face>
                        <Face id="7" plane="-0.189011 -0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707109 0 4.14098 0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 0 8" />
                        </Face>
                        <Face id="8" plane="-0.0691896 -0.258196 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 4.14106 0.249401 0.930778 -0.267303 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 10 0 9" />
                        </Face>
                        <Face id="9" plane="0.069185 -0.258198 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258823 0 4.14116 -0.249404 0.930777 -0.267304 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 0 10" />
                        </Face>
                        <Face id="10" plane="0.189012 -0.189017 -0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 4.14117 -0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 0 11" />
                        </Face>
                        <Face id="11" plane="0.258199 -0.0691766 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258814 0.965927 0 4.14121 -0.930779 0.249398 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 2 0" />
                        </Face>
                        <Face id="12" plane="0.694746 0.186155 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 -0.671074 -0.179813 -0.719255 -9.19553 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 14 13 1 2" />
                        </Face>
                        <Face id="13" plane="0.508593 0.508583 -0.694749 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 7.17272 -0.491259 -0.491261 -0.719255 -9.19557 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 3 1 13" />
                        </Face>
                        <Face id="14" plane="0.186185 0.694745 -0.69474 -0.949037" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17269 -0.179811 -0.671074 -0.719255 -9.1956 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 16 4 3 15" />
                        </Face>
                        <Face id="15" plane="-0.186176 0.694738 -0.69475 -0.949045" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 0.179816 -0.671074 -0.719254 -9.19558 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 5 4 16" />
                        </Face>
                        <Face id="16" plane="-0.508582 0.508602 -0.694743 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 0.491261 -0.491261 -0.719253 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 18 6 5 17" />
                        </Face>
                        <Face id="17" plane="-0.694746 0.186167 -0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17252 0.671074 -0.179816 -0.719254 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 7 6 18" />
                        </Face>
                        <Face id="18" plane="-0.694751 -0.186145 -0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 0.671074 0.179812 -0.719255 -9.19549 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 20 8 7 19" />
                        </Face>
                        <Face id="19" plane="-0.508598 -0.50858 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 7.17249 0.491261 0.49126 -0.719254 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 9 8 20" />
                        </Face>
                        <Face id="20" plane="-0.18617 -0.694745 -0.694745 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258817 0 7.17263 0.179813 0.671074 -0.719255 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 22 10 9 21" />
                        </Face>
                        <Face id="21" plane="0.186155 -0.694744 -0.69475 -0.949044" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 -0.179814 0.671074 -0.719254 -9.19542 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 11 10 22" />
                        </Face>
                        <Face id="22" plane="0.50859 -0.508588 -0.694747 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.707109 0 7.17273 -0.491262 0.491258 -0.719255 -9.19545 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 12 11 23" />
                        </Face>
                        <Face id="23" plane="0.694738 -0.186155 -0.694755 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17274 -0.671074 0.179811 -0.719255 -9.1955 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 14 2 12" />
                        </Face>
                        <Face id="24" plane="0.935113 0.250562 -0.250563 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28236 -0.242025 -0.0648507 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 26 25 13 14" />
                        </Face>
                        <Face id="25" plane="0.684533 0.684564 -0.25057 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 8.2823 -0.177175 -0.177175 -0.9681 -8.78248 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 15 13 25" />
                        </Face>
                        <Face id="26" plane="0.250583 0.935109 -0.250557 -0.935106" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28229 -0.0648499 -0.242027 -0.9681 -8.78245 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 28 16 15 27" />
                        </Face>
                        <Face id="27" plane="-0.25056 0.935116 -0.250554 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 0.0648515 -0.242025 -0.9681 -8.78249 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 17 16 28" />
                        </Face>
                        <Face id="28" plane="-0.684553 0.68455 -0.250557 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 0.177174 -0.177174 -0.968101 -8.78251 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 18 17 29" />
                        </Face>
                        <Face id="29" plane="-0.935114 0.250557 -0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28208 0.242025 -0.0648515 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 19 18 30" />
                        </Face>
                        <Face id="30" plane="-0.935116 -0.250555 -0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 0.242025 0.0648499 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 32 20 19 31" />
                        </Face>
                        <Face id="31" plane="-0.684544 -0.684557 -0.25056 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 0.177174 0.177174 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 33 21 20 32" />
                        </Face>
                        <Face id="32" plane="-0.250568 -0.935113 -0.250557 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.25882 0 8.28216 0.0648506 0.242025 -0.9681 -8.78243 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 34 22 21 33" />
                        </Face>
                        <Face id="33" plane="0.250578 -0.93511 -0.250559 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 -0.064851 0.242025 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 35 23 22 34" />
                        </Face>
                        <Face id="34" plane="0.684545 -0.684556 -0.250563 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 -0.177175 0.177174 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 24 23 35" />
                        </Face>
                        <Face id="35" plane="0.935114 -0.250561 -0.25056 -0.935115" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 -0.242025 0.0648494 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 26 14 24" />
                        </Face>
                        <Face id="36" plane="0.935113 0.250563 0.250562 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28235 0.242024 0.0648504 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 38 37 25 26" />
                        </Face>
                        <Face id="37" plane="0.684548 0.684554 0.25056 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 8.28229 0.177175 0.177175 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 39 27 25 37" />
                        </Face>
                        <Face id="38" plane="0.250565 0.935114 0.250559 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28228 0.0648496 0.242026 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 40 28 27 39" />
                        </Face>
                        <Face id="39" plane="-0.250554 0.935115 0.250567 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 -0.0648514 0.242025 -0.9681 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 41 29 28 40" />
                        </Face>
                        <Face id="40" plane="-0.684554 0.684546 0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 -0.177174 0.177174 -0.968101 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 42 30 29 41" />
                        </Face>
                        <Face id="41" plane="-0.935113 0.250566 0.250561 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28207 -0.242026 0.0648517 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 43 31 30 42" />
                        </Face>
                        <Face id="42" plane="-0.935113 -0.250561 0.250563 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 -0.242026 -0.0648501 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 44 32 31 43" />
                        </Face>
                        <Face id="43" plane="-0.684555 -0.684544 0.250569 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 -0.177174 -0.177174 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 45 33 32 44" />
                        </Face>
                        <Face id="44" plane="-0.250547 -0.935117 0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 8.28217 -0.0648506 -0.242026 -0.9681 -7.7449 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 46 34 33 45" />
                        </Face>
                        <Face id="45" plane="0.250571 -0.935114 0.250552 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 0.0648508 -0.242025 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 47 35 34 46" />
                        </Face>
                        <Face id="46" plane="0.68455 -0.684552 0.250559 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 0.177176 -0.177175 -0.9681 -7.74491 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 36 35 47" />
                        </Face>
                        <Face id="47" plane="0.935115 -0.25056 0.250561 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 0.242026 -0.0648496 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 38 26 36" />
                        </Face>
                        <Face id="48" plane="0.694747 0.186155 0.694747 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 0.671072 0.179812 -0.719257 -7.08919 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 50 49 37 38" />
                        </Face>
                        <Face id="49" plane="0.508588 0.508596 0.694744 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707108 0.707106 0 7.17272 0.491258 0.49126 -0.719256 -7.08917 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 51 39 37 49" />
                        </Face>
                        <Face id="50" plane="0.186149 0.694749 0.694747 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17268 0.17981 0.671072 -0.719257 -7.08913 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 52 40 39 51" />
                        </Face>
                        <Face id="51" plane="-0.186159 0.694743 0.69475 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 -0.179815 0.671072 -0.719256 -7.08915 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 53 41 40 52" />
                        </Face>
                        <Face id="52" plane="-0.508583 0.508594 0.694749 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 -0.491259 0.491259 -0.719257 -7.08918 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 54 42 41 53" />
                        </Face>
                        <Face id="53" plane="-0.694746 0.186158 0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17253 -0.671072 0.179815 -0.719256 -7.0892 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 55 43 42 54" />
                        </Face>
                        <Face id="54" plane="-0.694746 -0.186159 0.694747 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 -0.671072 -0.179812 -0.719257 -7.08923 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 56 44 43 55" />
                        </Face>
                        <Face id="55" plane="-0.508592 -0.508591 0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707108 0 7.17249 -0.49126 -0.491258 -0.719256 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 57 45 44 56" />
                        </Face>
                        <Face id="56" plane="-0.186154 -0.69475 0.694744 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 7.17262 -0.179812 -0.671072 -0.719257 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 58 46 45 57" />
                        </Face>
                        <Face id="57" plane="0.186129 -0.694755 0.694746 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 0.179814 -0.671072 -0.719256 -7.0893 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 59 47 46 58" />
                        </Face>
                        <Face id="58" plane="0.508605 -0.508572 0.694748 -0.949043" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 7.17272 0.49126 -0.491257 -0.719257 -7.08927 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 48 47 59" />
                        </Face>
                        <Face id="59" plane="0.694745 -0.186155 0.694748 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17273 0.671072 -0.179811 -0.719257 -7.08922 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 50 38 48" />
                        </Face>
                        <Face id="60" plane="0.258195 0.0691838 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258819 0.965926 0 4.1412 0.930779 0.249401 -0.267302 -7.48467 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 49 50" />
                        </Face>
                        <Face id="61" plane="0.189004 0.189019 0.963613 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 4.14117 0.681376 0.681376 -0.267306 -7.4845 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 51 49" />
                        </Face>
                        <Face id="62" plane="0.0691902 0.258196 0.963612 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 4.14115 0.249397 0.93078 -0.267302 -7.48458 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 52 51" />
                        </Face>
                        <Face id="63" plane="-0.069185 0.258198 0.963611 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 -0.249404 0.930778 -0.267302 -7.48459 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 53 52" />
                        </Face>
                        <Face id="64" plane="-0.18901 0.189019 0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707106 0 4.14093 -0.681377 0.681377 -0.267302 -7.48464 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 54 53" />
                        </Face>
                        <Face id="65" plane="-0.258201 0.069179 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 4.14099 -0.930778 0.249404 -0.267302 -7.48468 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 55 54" />
                        </Face>
                        <Face id="66" plane="-0.258204 -0.0691815 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258819 -0.965926 0 4.141 -0.930777 -0.249401 -0.267306 -7.48461 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 56 55" />
                        </Face>
                        <Face id="67" plane="-0.189012 -0.189023 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 4.14099 -0.681379 -0.681375 -0.267303 -7.48476 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 57 56" />
                        </Face>
                        <Face id="68" plane="-0.0691892 -0.258205 0.963609 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 4.14106 -0.249401 -0.930779 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 58 57" />
                        </Face>
                        <Face id="69" plane="0.0691877 -0.258201 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258822 0 4.14115 0.249404 -0.930778 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 59 58" />
                        </Face>
                        <Face id="70" plane="0.189011 -0.189022 0.963611 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.70711 0 4.14118 0.681378 -0.681374 -0.267306 -7.48465 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 60 59" />
                        </Face>
                        <Face id="71" plane="0.258197 -0.0691834 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 4.1412 0.930779 -0.249397 -0.267302 -7.48472 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 50 60" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-3 43.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 43.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="73" nextVertexID="63">
                        <Vertices>
                            <Vertex pos="5.00679e-006 -3.8147e-006 -0.999999" />
                            <Vertex pos="0.433012 0.249992 -0.866029" />
                            <Vertex pos="0.499995 1.14441e-005 -0.866028" />
                            <Vertex pos="0.25001 0.432999 -0.866028" />
                            <Vertex pos="-1.00136e-005 0.500004 -0.866026" />
                            <Vertex pos="-0.24999 0.43301 -0.86603" />
                            <Vertex pos="-0.43301 0.25 -0.866028" />
                            <Vertex pos="-0.499998 1.14441e-005 -0.866028" />
                            <Vertex pos="-0.433014 -0.249992 -0.866028" />
                            <Vertex pos="-0.250009 -0.433006 -0.866027" />
                            <Vertex pos="-1.90735e-006 -0.5 -0.866027" />
                            <Vertex pos="0.249998 -0.433014 -0.866026" />
                            <Vertex pos="0.433016 -0.249992 -0.866028" />
                            <Vertex pos="0.749996 0.433022 -0.500003" />
                            <Vertex pos="0.866025 -7.62939e-006 -0.500003" />
                            <Vertex pos="0.433015 0.749985 -0.500012" />
                            <Vertex pos="-1.19209e-006 0.866024 -0.500001" />
                            <Vertex pos="-0.433016 0.75 -0.499999" />
                            <Vertex pos="-0.750001 0.433014 -0.499998" />
                            <Vertex pos="-0.866022 0 -0.500006" />
                            <Vertex pos="-0.75 -0.433018 -0.500001" />
                            <Vertex pos="-0.433013 -0.749996 -0.500009" />
                            <Vertex pos="6.91414e-006 -0.866028 -0.500002" />
                            <Vertex pos="0.433006 -0.749996 -0.500011" />
                            <Vertex pos="0.750005 -0.433006 -0.500001" />
                            <Vertex pos="0.866024 0.5 -2.92063e-006" />
                            <Vertex pos="0.999999 -3.8147e-006 -2.26498e-006" />
                            <Vertex pos="0.5 0.86602 -2.68221e-006" />
                            <Vertex pos="-1.90735e-006 0.999996 -1.78814e-006" />
                            <Vertex pos="-0.5 0.866024 1.03712e-005" />
                            <Vertex pos="-0.866019 0.500004 1.07288e-006" />
                            <Vertex pos="-0.999999 -3.8147e-006 -2.74181e-006" />
                            <Vertex pos="-0.866027 -0.499996 -2.38419e-006" />
                            <Vertex pos="-0.499998 -0.866028 8.70228e-006" />
                            <Vertex pos="-1.90735e-006 -0.999996 -5.06639e-006" />
                            <Vertex pos="0.500005 -0.866016 -7.86781e-006" />
                            <Vertex pos="0.866026 -0.499996 -6.97374e-006" />
                            <Vertex pos="0.749999 0.43301 0.5" />
                            <Vertex pos="0.866026 -3.8147e-006 0.499997" />
                            <Vertex pos="0.433007 0.750004 0.499995" />
                            <Vertex pos="-1.16825e-005 0.866028 0.499993" />
                            <Vertex pos="-0.433012 0.75 0.499996" />
                            <Vertex pos="-0.749995 0.433014 0.500003" />
                            <Vertex pos="-0.866022 0 0.500003" />
                            <Vertex pos="-0.75 -0.433014 0.499998" />
                            <Vertex pos="-0.433018 -0.749992 0.500002" />
                            <Vertex pos="-9.77516e-006 -0.86602 0.499996" />
                            <Vertex pos="0.433016 -0.749992 0.500014" />
                            <Vertex pos="0.750005 -0.433006 0.499996" />
                            <Vertex pos="0.433008 0.250008 0.866025" />
                            <Vertex pos="0.499997 0 0.866026" />
                            <Vertex pos="0.250006 0.433006 0.866023" />
                            <Vertex pos="1.43051e-006 0.499992 0.866026" />
                            <Vertex pos="-0.250002 0.433006 0.866025" />
                            <Vertex pos="-0.433011 0.249996 0.866027" />
                            <Vertex pos="-0.5 3.8147e-006 0.866024" />
                            <Vertex pos="-0.433009 -0.250008 0.866026" />
                            <Vertex pos="-0.250009 -0.43301 0.866023" />
                            <Vertex pos="1.16825e-005 -0.5 0.866025" />
                            <Vertex pos="0.249988 -0.433022 0.866023" />
                            <Vertex pos="0.433011 -0.249996 0.866026" />
                            <Vertex pos="-5.96046e-006 -7.62939e-006 0.999999" />
                        </Vertices>
                        <Face id="0" plane="0.258195 0.0691836 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 4.14121 -0.930778 -0.249401 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0.189012 0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 0.707108 0 4.14116 -0.681377 -0.681377 -0.267303 -8.55392 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 0 1" />
                        </Face>
                        <Face id="2" plane="0.0691877 0.258195 -0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258814 0 4.14116 -0.249397 -0.930779 -0.267303 -8.55395 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3" />
                        </Face>
                        <Face id="3" plane="-0.06918 0.258191 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 0.249405 -0.930777 -0.267304 -8.55394 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 0 4" />
                        </Face>
                        <Face id="4" plane="-0.189008 0.18901 -0.963614 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 4.14093 0.681377 -0.681377 -0.267303 -8.5539 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 5" />
                        </Face>
                        <Face id="5" plane="-0.258189 0.0691859 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 4.141 0.930778 -0.249404 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 0 6" />
                        </Face>
                        <Face id="6" plane="-0.258193 -0.0691777 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258818 -0.965926 0 4.141 0.930778 0.249401 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 8 0 7" />
                        </Face>
                        <Face id="7" plane="-0.189011 -0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707109 0 4.14098 0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 0 8" />
                        </Face>
                        <Face id="8" plane="-0.0691896 -0.258196 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 4.14106 0.249401 0.930778 -0.267303 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 10 0 9" />
                        </Face>
                        <Face id="9" plane="0.069185 -0.258198 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258823 0 4.14116 -0.249404 0.930777 -0.267304 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 0 10" />
                        </Face>
                        <Face id="10" plane="0.189012 -0.189017 -0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 4.14117 -0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 0 11" />
                        </Face>
                        <Face id="11" plane="0.258199 -0.0691766 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258814 0.965927 0 4.14121 -0.930779 0.249398 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 2 0" />
                        </Face>
                        <Face id="12" plane="0.694746 0.186155 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 -0.671074 -0.179813 -0.719255 -9.19553 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 14 13 1 2" />
                        </Face>
                        <Face id="13" plane="0.508593 0.508583 -0.694749 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 7.17272 -0.491259 -0.491261 -0.719255 -9.19557 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 3 1 13" />
                        </Face>
                        <Face id="14" plane="0.186185 0.694745 -0.69474 -0.949037" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17269 -0.179811 -0.671074 -0.719255 -9.1956 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 16 4 3 15" />
                        </Face>
                        <Face id="15" plane="-0.186176 0.694738 -0.69475 -0.949045" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 0.179816 -0.671074 -0.719254 -9.19558 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 5 4 16" />
                        </Face>
                        <Face id="16" plane="-0.508582 0.508602 -0.694743 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 0.491261 -0.491261 -0.719253 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 18 6 5 17" />
                        </Face>
                        <Face id="17" plane="-0.694746 0.186167 -0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17252 0.671074 -0.179816 -0.719254 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 7 6 18" />
                        </Face>
                        <Face id="18" plane="-0.694751 -0.186145 -0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 0.671074 0.179812 -0.719255 -9.19549 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 20 8 7 19" />
                        </Face>
                        <Face id="19" plane="-0.508598 -0.50858 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 7.17249 0.491261 0.49126 -0.719254 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 9 8 20" />
                        </Face>
                        <Face id="20" plane="-0.18617 -0.694745 -0.694745 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258817 0 7.17263 0.179813 0.671074 -0.719255 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 22 10 9 21" />
                        </Face>
                        <Face id="21" plane="0.186155 -0.694744 -0.69475 -0.949044" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 -0.179814 0.671074 -0.719254 -9.19542 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 11 10 22" />
                        </Face>
                        <Face id="22" plane="0.50859 -0.508588 -0.694747 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.707109 0 7.17273 -0.491262 0.491258 -0.719255 -9.19545 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 12 11 23" />
                        </Face>
                        <Face id="23" plane="0.694738 -0.186155 -0.694755 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17274 -0.671074 0.179811 -0.719255 -9.1955 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 14 2 12" />
                        </Face>
                        <Face id="24" plane="0.935113 0.250562 -0.250563 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28236 -0.242025 -0.0648507 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 26 25 13 14" />
                        </Face>
                        <Face id="25" plane="0.684533 0.684564 -0.25057 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 8.2823 -0.177175 -0.177175 -0.9681 -8.78248 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 15 13 25" />
                        </Face>
                        <Face id="26" plane="0.250583 0.935109 -0.250557 -0.935106" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28229 -0.0648499 -0.242027 -0.9681 -8.78245 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 28 16 15 27" />
                        </Face>
                        <Face id="27" plane="-0.25056 0.935116 -0.250554 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 0.0648515 -0.242025 -0.9681 -8.78249 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 17 16 28" />
                        </Face>
                        <Face id="28" plane="-0.684553 0.68455 -0.250557 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 0.177174 -0.177174 -0.968101 -8.78251 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 18 17 29" />
                        </Face>
                        <Face id="29" plane="-0.935114 0.250557 -0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28208 0.242025 -0.0648515 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 19 18 30" />
                        </Face>
                        <Face id="30" plane="-0.935116 -0.250555 -0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 0.242025 0.0648499 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 32 20 19 31" />
                        </Face>
                        <Face id="31" plane="-0.684544 -0.684557 -0.25056 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 0.177174 0.177174 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 33 21 20 32" />
                        </Face>
                        <Face id="32" plane="-0.250568 -0.935113 -0.250557 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.25882 0 8.28216 0.0648506 0.242025 -0.9681 -8.78243 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 34 22 21 33" />
                        </Face>
                        <Face id="33" plane="0.250578 -0.93511 -0.250559 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 -0.064851 0.242025 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 35 23 22 34" />
                        </Face>
                        <Face id="34" plane="0.684545 -0.684556 -0.250563 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 -0.177175 0.177174 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 24 23 35" />
                        </Face>
                        <Face id="35" plane="0.935114 -0.250561 -0.25056 -0.935115" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 -0.242025 0.0648494 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 26 14 24" />
                        </Face>
                        <Face id="36" plane="0.935113 0.250563 0.250562 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28235 0.242024 0.0648504 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 38 37 25 26" />
                        </Face>
                        <Face id="37" plane="0.684548 0.684554 0.25056 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 8.28229 0.177175 0.177175 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 39 27 25 37" />
                        </Face>
                        <Face id="38" plane="0.250565 0.935114 0.250559 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28228 0.0648496 0.242026 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 40 28 27 39" />
                        </Face>
                        <Face id="39" plane="-0.250554 0.935115 0.250567 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 -0.0648514 0.242025 -0.9681 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 41 29 28 40" />
                        </Face>
                        <Face id="40" plane="-0.684554 0.684546 0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 -0.177174 0.177174 -0.968101 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 42 30 29 41" />
                        </Face>
                        <Face id="41" plane="-0.935113 0.250566 0.250561 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28207 -0.242026 0.0648517 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 43 31 30 42" />
                        </Face>
                        <Face id="42" plane="-0.935113 -0.250561 0.250563 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 -0.242026 -0.0648501 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 44 32 31 43" />
                        </Face>
                        <Face id="43" plane="-0.684555 -0.684544 0.250569 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 -0.177174 -0.177174 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 45 33 32 44" />
                        </Face>
                        <Face id="44" plane="-0.250547 -0.935117 0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 8.28217 -0.0648506 -0.242026 -0.9681 -7.7449 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 46 34 33 45" />
                        </Face>
                        <Face id="45" plane="0.250571 -0.935114 0.250552 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 0.0648508 -0.242025 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 47 35 34 46" />
                        </Face>
                        <Face id="46" plane="0.68455 -0.684552 0.250559 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 0.177176 -0.177175 -0.9681 -7.74491 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 36 35 47" />
                        </Face>
                        <Face id="47" plane="0.935115 -0.25056 0.250561 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 0.242026 -0.0648496 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 38 26 36" />
                        </Face>
                        <Face id="48" plane="0.694747 0.186155 0.694747 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 0.671072 0.179812 -0.719257 -7.08919 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 50 49 37 38" />
                        </Face>
                        <Face id="49" plane="0.508588 0.508596 0.694744 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707108 0.707106 0 7.17272 0.491258 0.49126 -0.719256 -7.08917 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 51 39 37 49" />
                        </Face>
                        <Face id="50" plane="0.186149 0.694749 0.694747 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17268 0.17981 0.671072 -0.719257 -7.08913 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 52 40 39 51" />
                        </Face>
                        <Face id="51" plane="-0.186159 0.694743 0.69475 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 -0.179815 0.671072 -0.719256 -7.08915 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 53 41 40 52" />
                        </Face>
                        <Face id="52" plane="-0.508583 0.508594 0.694749 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 -0.491259 0.491259 -0.719257 -7.08918 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 54 42 41 53" />
                        </Face>
                        <Face id="53" plane="-0.694746 0.186158 0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17253 -0.671072 0.179815 -0.719256 -7.0892 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 55 43 42 54" />
                        </Face>
                        <Face id="54" plane="-0.694746 -0.186159 0.694747 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 -0.671072 -0.179812 -0.719257 -7.08923 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 56 44 43 55" />
                        </Face>
                        <Face id="55" plane="-0.508592 -0.508591 0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707108 0 7.17249 -0.49126 -0.491258 -0.719256 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 57 45 44 56" />
                        </Face>
                        <Face id="56" plane="-0.186154 -0.69475 0.694744 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 7.17262 -0.179812 -0.671072 -0.719257 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 58 46 45 57" />
                        </Face>
                        <Face id="57" plane="0.186129 -0.694755 0.694746 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 0.179814 -0.671072 -0.719256 -7.0893 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 59 47 46 58" />
                        </Face>
                        <Face id="58" plane="0.508605 -0.508572 0.694748 -0.949043" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 7.17272 0.49126 -0.491257 -0.719257 -7.08927 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 48 47 59" />
                        </Face>
                        <Face id="59" plane="0.694745 -0.186155 0.694748 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17273 0.671072 -0.179811 -0.719257 -7.08922 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 50 38 48" />
                        </Face>
                        <Face id="60" plane="0.258195 0.0691838 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258819 0.965926 0 4.1412 0.930779 0.249401 -0.267302 -7.48467 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 49 50" />
                        </Face>
                        <Face id="61" plane="0.189004 0.189019 0.963613 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 4.14117 0.681376 0.681376 -0.267306 -7.4845 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 51 49" />
                        </Face>
                        <Face id="62" plane="0.0691902 0.258196 0.963612 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 4.14115 0.249397 0.93078 -0.267302 -7.48458 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 52 51" />
                        </Face>
                        <Face id="63" plane="-0.069185 0.258198 0.963611 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 -0.249404 0.930778 -0.267302 -7.48459 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 53 52" />
                        </Face>
                        <Face id="64" plane="-0.18901 0.189019 0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707106 0 4.14093 -0.681377 0.681377 -0.267302 -7.48464 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 54 53" />
                        </Face>
                        <Face id="65" plane="-0.258201 0.069179 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 4.14099 -0.930778 0.249404 -0.267302 -7.48468 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 55 54" />
                        </Face>
                        <Face id="66" plane="-0.258204 -0.0691815 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258819 -0.965926 0 4.141 -0.930777 -0.249401 -0.267306 -7.48461 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 56 55" />
                        </Face>
                        <Face id="67" plane="-0.189012 -0.189023 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 4.14099 -0.681379 -0.681375 -0.267303 -7.48476 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 57 56" />
                        </Face>
                        <Face id="68" plane="-0.0691892 -0.258205 0.963609 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 4.14106 -0.249401 -0.930779 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 58 57" />
                        </Face>
                        <Face id="69" plane="0.0691877 -0.258201 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258822 0 4.14115 0.249404 -0.930778 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 59 58" />
                        </Face>
                        <Face id="70" plane="0.189011 -0.189022 0.963611 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.70711 0 4.14118 0.681378 -0.681374 -0.267306 -7.48465 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 60 59" />
                        </Face>
                        <Face id="71" plane="0.258197 -0.0691834 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 4.1412 0.930779 -0.249397 -0.267302 -7.48472 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 50 60" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-3 46.5 10" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 1 0 46.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="73" nextVertexID="63">
                        <Vertices>
                            <Vertex pos="5.00679e-006 -3.8147e-006 -0.999999" />
                            <Vertex pos="0.433012 0.249992 -0.866029" />
                            <Vertex pos="0.499995 1.14441e-005 -0.866028" />
                            <Vertex pos="0.25001 0.432999 -0.866028" />
                            <Vertex pos="-1.00136e-005 0.500004 -0.866026" />
                            <Vertex pos="-0.24999 0.43301 -0.86603" />
                            <Vertex pos="-0.43301 0.25 -0.866028" />
                            <Vertex pos="-0.499998 1.14441e-005 -0.866028" />
                            <Vertex pos="-0.433014 -0.249992 -0.866028" />
                            <Vertex pos="-0.250009 -0.433006 -0.866027" />
                            <Vertex pos="-1.90735e-006 -0.5 -0.866027" />
                            <Vertex pos="0.249998 -0.433014 -0.866026" />
                            <Vertex pos="0.433016 -0.249992 -0.866028" />
                            <Vertex pos="0.749996 0.433022 -0.500003" />
                            <Vertex pos="0.866025 -7.62939e-006 -0.500003" />
                            <Vertex pos="0.433015 0.749985 -0.500012" />
                            <Vertex pos="-1.19209e-006 0.866024 -0.500001" />
                            <Vertex pos="-0.433016 0.75 -0.499999" />
                            <Vertex pos="-0.750001 0.433014 -0.499998" />
                            <Vertex pos="-0.866022 0 -0.500006" />
                            <Vertex pos="-0.75 -0.433018 -0.500001" />
                            <Vertex pos="-0.433013 -0.749996 -0.500009" />
                            <Vertex pos="6.91414e-006 -0.866028 -0.500002" />
                            <Vertex pos="0.433006 -0.749996 -0.500011" />
                            <Vertex pos="0.750005 -0.433006 -0.500001" />
                            <Vertex pos="0.866024 0.5 -2.92063e-006" />
                            <Vertex pos="0.999999 -3.8147e-006 -2.26498e-006" />
                            <Vertex pos="0.5 0.86602 -2.68221e-006" />
                            <Vertex pos="-1.90735e-006 0.999996 -1.78814e-006" />
                            <Vertex pos="-0.5 0.866024 1.03712e-005" />
                            <Vertex pos="-0.866019 0.500004 1.07288e-006" />
                            <Vertex pos="-0.999999 -3.8147e-006 -2.74181e-006" />
                            <Vertex pos="-0.866027 -0.499996 -2.38419e-006" />
                            <Vertex pos="-0.499998 -0.866028 8.70228e-006" />
                            <Vertex pos="-1.90735e-006 -0.999996 -5.06639e-006" />
                            <Vertex pos="0.500005 -0.866016 -7.86781e-006" />
                            <Vertex pos="0.866026 -0.499996 -6.97374e-006" />
                            <Vertex pos="0.749999 0.43301 0.5" />
                            <Vertex pos="0.866026 -3.8147e-006 0.499997" />
                            <Vertex pos="0.433007 0.750004 0.499995" />
                            <Vertex pos="-1.16825e-005 0.866028 0.499993" />
                            <Vertex pos="-0.433012 0.75 0.499996" />
                            <Vertex pos="-0.749995 0.433014 0.500003" />
                            <Vertex pos="-0.866022 0 0.500003" />
                            <Vertex pos="-0.75 -0.433014 0.499998" />
                            <Vertex pos="-0.433018 -0.749992 0.500002" />
                            <Vertex pos="-9.77516e-006 -0.86602 0.499996" />
                            <Vertex pos="0.433016 -0.749992 0.500014" />
                            <Vertex pos="0.750005 -0.433006 0.499996" />
                            <Vertex pos="0.433008 0.250008 0.866025" />
                            <Vertex pos="0.499997 0 0.866026" />
                            <Vertex pos="0.250006 0.433006 0.866023" />
                            <Vertex pos="1.43051e-006 0.499992 0.866026" />
                            <Vertex pos="-0.250002 0.433006 0.866025" />
                            <Vertex pos="-0.433011 0.249996 0.866027" />
                            <Vertex pos="-0.5 3.8147e-006 0.866024" />
                            <Vertex pos="-0.433009 -0.250008 0.866026" />
                            <Vertex pos="-0.250009 -0.43301 0.866023" />
                            <Vertex pos="1.16825e-005 -0.5 0.866025" />
                            <Vertex pos="0.249988 -0.433022 0.866023" />
                            <Vertex pos="0.433011 -0.249996 0.866026" />
                            <Vertex pos="-5.96046e-006 -7.62939e-006 0.999999" />
                        </Vertices>
                        <Face id="0" plane="0.258195 0.0691836 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 4.14121 -0.930778 -0.249401 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0.189012 0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 0.707108 0 4.14116 -0.681377 -0.681377 -0.267303 -8.55392 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 0 1" />
                        </Face>
                        <Face id="2" plane="0.0691877 0.258195 -0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258814 0 4.14116 -0.249397 -0.930779 -0.267303 -8.55395 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3" />
                        </Face>
                        <Face id="3" plane="-0.06918 0.258191 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 0.249405 -0.930777 -0.267304 -8.55394 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 0 4" />
                        </Face>
                        <Face id="4" plane="-0.189008 0.18901 -0.963614 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 4.14093 0.681377 -0.681377 -0.267303 -8.5539 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 5" />
                        </Face>
                        <Face id="5" plane="-0.258189 0.0691859 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 4.141 0.930778 -0.249404 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 0 6" />
                        </Face>
                        <Face id="6" plane="-0.258193 -0.0691777 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258818 -0.965926 0 4.141 0.930778 0.249401 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 8 0 7" />
                        </Face>
                        <Face id="7" plane="-0.189011 -0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707109 0 4.14098 0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 0 8" />
                        </Face>
                        <Face id="8" plane="-0.0691896 -0.258196 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 4.14106 0.249401 0.930778 -0.267303 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 10 0 9" />
                        </Face>
                        <Face id="9" plane="0.069185 -0.258198 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258823 0 4.14116 -0.249404 0.930777 -0.267304 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 0 10" />
                        </Face>
                        <Face id="10" plane="0.189012 -0.189017 -0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 4.14117 -0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 0 11" />
                        </Face>
                        <Face id="11" plane="0.258199 -0.0691766 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258814 0.965927 0 4.14121 -0.930779 0.249398 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 2 0" />
                        </Face>
                        <Face id="12" plane="0.694746 0.186155 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 -0.671074 -0.179813 -0.719255 -9.19553 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 14 13 1 2" />
                        </Face>
                        <Face id="13" plane="0.508593 0.508583 -0.694749 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 7.17272 -0.491259 -0.491261 -0.719255 -9.19557 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 3 1 13" />
                        </Face>
                        <Face id="14" plane="0.186185 0.694745 -0.69474 -0.949037" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17269 -0.179811 -0.671074 -0.719255 -9.1956 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 16 4 3 15" />
                        </Face>
                        <Face id="15" plane="-0.186176 0.694738 -0.69475 -0.949045" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 0.179816 -0.671074 -0.719254 -9.19558 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 5 4 16" />
                        </Face>
                        <Face id="16" plane="-0.508582 0.508602 -0.694743 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 0.491261 -0.491261 -0.719253 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 18 6 5 17" />
                        </Face>
                        <Face id="17" plane="-0.694746 0.186167 -0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17252 0.671074 -0.179816 -0.719254 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 7 6 18" />
                        </Face>
                        <Face id="18" plane="-0.694751 -0.186145 -0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 0.671074 0.179812 -0.719255 -9.19549 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 20 8 7 19" />
                        </Face>
                        <Face id="19" plane="-0.508598 -0.50858 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 7.17249 0.491261 0.49126 -0.719254 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 9 8 20" />
                        </Face>
                        <Face id="20" plane="-0.18617 -0.694745 -0.694745 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258817 0 7.17263 0.179813 0.671074 -0.719255 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 22 10 9 21" />
                        </Face>
                        <Face id="21" plane="0.186155 -0.694744 -0.69475 -0.949044" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 -0.179814 0.671074 -0.719254 -9.19542 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 11 10 22" />
                        </Face>
                        <Face id="22" plane="0.50859 -0.508588 -0.694747 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.707109 0 7.17273 -0.491262 0.491258 -0.719255 -9.19545 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 12 11 23" />
                        </Face>
                        <Face id="23" plane="0.694738 -0.186155 -0.694755 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17274 -0.671074 0.179811 -0.719255 -9.1955 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 14 2 12" />
                        </Face>
                        <Face id="24" plane="0.935113 0.250562 -0.250563 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28236 -0.242025 -0.0648507 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 26 25 13 14" />
                        </Face>
                        <Face id="25" plane="0.684533 0.684564 -0.25057 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 8.2823 -0.177175 -0.177175 -0.9681 -8.78248 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 15 13 25" />
                        </Face>
                        <Face id="26" plane="0.250583 0.935109 -0.250557 -0.935106" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28229 -0.0648499 -0.242027 -0.9681 -8.78245 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 28 16 15 27" />
                        </Face>
                        <Face id="27" plane="-0.25056 0.935116 -0.250554 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 0.0648515 -0.242025 -0.9681 -8.78249 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 17 16 28" />
                        </Face>
                        <Face id="28" plane="-0.684553 0.68455 -0.250557 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 0.177174 -0.177174 -0.968101 -8.78251 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 18 17 29" />
                        </Face>
                        <Face id="29" plane="-0.935114 0.250557 -0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28208 0.242025 -0.0648515 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 19 18 30" />
                        </Face>
                        <Face id="30" plane="-0.935116 -0.250555 -0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 0.242025 0.0648499 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 32 20 19 31" />
                        </Face>
                        <Face id="31" plane="-0.684544 -0.684557 -0.25056 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 0.177174 0.177174 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 33 21 20 32" />
                        </Face>
                        <Face id="32" plane="-0.250568 -0.935113 -0.250557 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.25882 0 8.28216 0.0648506 0.242025 -0.9681 -8.78243 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 34 22 21 33" />
                        </Face>
                        <Face id="33" plane="0.250578 -0.93511 -0.250559 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 -0.064851 0.242025 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 35 23 22 34" />
                        </Face>
                        <Face id="34" plane="0.684545 -0.684556 -0.250563 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 -0.177175 0.177174 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 24 23 35" />
                        </Face>
                        <Face id="35" plane="0.935114 -0.250561 -0.25056 -0.935115" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 -0.242025 0.0648494 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 26 14 24" />
                        </Face>
                        <Face id="36" plane="0.935113 0.250563 0.250562 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28235 0.242024 0.0648504 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 38 37 25 26" />
                        </Face>
                        <Face id="37" plane="0.684548 0.684554 0.25056 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 8.28229 0.177175 0.177175 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 39 27 25 37" />
                        </Face>
                        <Face id="38" plane="0.250565 0.935114 0.250559 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28228 0.0648496 0.242026 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 40 28 27 39" />
                        </Face>
                        <Face id="39" plane="-0.250554 0.935115 0.250567 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 -0.0648514 0.242025 -0.9681 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 41 29 28 40" />
                        </Face>
                        <Face id="40" plane="-0.684554 0.684546 0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 -0.177174 0.177174 -0.968101 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 42 30 29 41" />
                        </Face>
                        <Face id="41" plane="-0.935113 0.250566 0.250561 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28207 -0.242026 0.0648517 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 43 31 30 42" />
                        </Face>
                        <Face id="42" plane="-0.935113 -0.250561 0.250563 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 -0.242026 -0.0648501 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 44 32 31 43" />
                        </Face>
                        <Face id="43" plane="-0.684555 -0.684544 0.250569 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 -0.177174 -0.177174 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 45 33 32 44" />
                        </Face>
                        <Face id="44" plane="-0.250547 -0.935117 0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 8.28217 -0.0648506 -0.242026 -0.9681 -7.7449 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 46 34 33 45" />
                        </Face>
                        <Face id="45" plane="0.250571 -0.935114 0.250552 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 0.0648508 -0.242025 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 47 35 34 46" />
                        </Face>
                        <Face id="46" plane="0.68455 -0.684552 0.250559 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 0.177176 -0.177175 -0.9681 -7.74491 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 36 35 47" />
                        </Face>
                        <Face id="47" plane="0.935115 -0.25056 0.250561 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 0.242026 -0.0648496 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 38 26 36" />
                        </Face>
                        <Face id="48" plane="0.694747 0.186155 0.694747 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 0.671072 0.179812 -0.719257 -7.08919 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 50 49 37 38" />
                        </Face>
                        <Face id="49" plane="0.508588 0.508596 0.694744 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707108 0.707106 0 7.17272 0.491258 0.49126 -0.719256 -7.08917 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 51 39 37 49" />
                        </Face>
                        <Face id="50" plane="0.186149 0.694749 0.694747 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17268 0.17981 0.671072 -0.719257 -7.08913 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 52 40 39 51" />
                        </Face>
                        <Face id="51" plane="-0.186159 0.694743 0.69475 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 -0.179815 0.671072 -0.719256 -7.08915 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 53 41 40 52" />
                        </Face>
                        <Face id="52" plane="-0.508583 0.508594 0.694749 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 -0.491259 0.491259 -0.719257 -7.08918 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 54 42 41 53" />
                        </Face>
                        <Face id="53" plane="-0.694746 0.186158 0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17253 -0.671072 0.179815 -0.719256 -7.0892 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 55 43 42 54" />
                        </Face>
                        <Face id="54" plane="-0.694746 -0.186159 0.694747 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 -0.671072 -0.179812 -0.719257 -7.08923 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 56 44 43 55" />
                        </Face>
                        <Face id="55" plane="-0.508592 -0.508591 0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707108 0 7.17249 -0.49126 -0.491258 -0.719256 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 57 45 44 56" />
                        </Face>
                        <Face id="56" plane="-0.186154 -0.69475 0.694744 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 7.17262 -0.179812 -0.671072 -0.719257 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 58 46 45 57" />
                        </Face>
                        <Face id="57" plane="0.186129 -0.694755 0.694746 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 0.179814 -0.671072 -0.719256 -7.0893 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 59 47 46 58" />
                        </Face>
                        <Face id="58" plane="0.508605 -0.508572 0.694748 -0.949043" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 7.17272 0.49126 -0.491257 -0.719257 -7.08927 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 48 47 59" />
                        </Face>
                        <Face id="59" plane="0.694745 -0.186155 0.694748 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17273 0.671072 -0.179811 -0.719257 -7.08922 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 50 38 48" />
                        </Face>
                        <Face id="60" plane="0.258195 0.0691838 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258819 0.965926 0 4.1412 0.930779 0.249401 -0.267302 -7.48467 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 49 50" />
                        </Face>
                        <Face id="61" plane="0.189004 0.189019 0.963613 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 4.14117 0.681376 0.681376 -0.267306 -7.4845 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 51 49" />
                        </Face>
                        <Face id="62" plane="0.0691902 0.258196 0.963612 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 4.14115 0.249397 0.93078 -0.267302 -7.48458 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 52 51" />
                        </Face>
                        <Face id="63" plane="-0.069185 0.258198 0.963611 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 -0.249404 0.930778 -0.267302 -7.48459 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 53 52" />
                        </Face>
                        <Face id="64" plane="-0.18901 0.189019 0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707106 0 4.14093 -0.681377 0.681377 -0.267302 -7.48464 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 54 53" />
                        </Face>
                        <Face id="65" plane="-0.258201 0.069179 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 4.14099 -0.930778 0.249404 -0.267302 -7.48468 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 55 54" />
                        </Face>
                        <Face id="66" plane="-0.258204 -0.0691815 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258819 -0.965926 0 4.141 -0.930777 -0.249401 -0.267306 -7.48461 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 56 55" />
                        </Face>
                        <Face id="67" plane="-0.189012 -0.189023 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 4.14099 -0.681379 -0.681375 -0.267303 -7.48476 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 57 56" />
                        </Face>
                        <Face id="68" plane="-0.0691892 -0.258205 0.963609 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 4.14106 -0.249401 -0.930779 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 58 57" />
                        </Face>
                        <Face id="69" plane="0.0691877 -0.258201 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258822 0 4.14115 0.249404 -0.930778 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 59 58" />
                        </Face>
                        <Face id="70" plane="0.189011 -0.189022 0.963611 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.70711 0 4.14118 0.681378 -0.681374 -0.267306 -7.48465 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 60 59" />
                        </Face>
                        <Face id="71" plane="0.258197 -0.0691834 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 4.1412 0.930779 -0.249397 -0.267302 -7.48472 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 50 60" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="0 46.5 10" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 46.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="73" nextVertexID="63">
                        <Vertices>
                            <Vertex pos="5.00679e-006 -3.8147e-006 -0.999999" />
                            <Vertex pos="0.433012 0.249992 -0.866029" />
                            <Vertex pos="0.499995 1.14441e-005 -0.866028" />
                            <Vertex pos="0.25001 0.432999 -0.866028" />
                            <Vertex pos="-1.00136e-005 0.500004 -0.866026" />
                            <Vertex pos="-0.24999 0.43301 -0.86603" />
                            <Vertex pos="-0.43301 0.25 -0.866028" />
                            <Vertex pos="-0.499998 1.14441e-005 -0.866028" />
                            <Vertex pos="-0.433014 -0.249992 -0.866028" />
                            <Vertex pos="-0.250009 -0.433006 -0.866027" />
                            <Vertex pos="-1.90735e-006 -0.5 -0.866027" />
                            <Vertex pos="0.249998 -0.433014 -0.866026" />
                            <Vertex pos="0.433016 -0.249992 -0.866028" />
                            <Vertex pos="0.749996 0.433022 -0.500003" />
                            <Vertex pos="0.866025 -7.62939e-006 -0.500003" />
                            <Vertex pos="0.433015 0.749985 -0.500012" />
                            <Vertex pos="-1.19209e-006 0.866024 -0.500001" />
                            <Vertex pos="-0.433016 0.75 -0.499999" />
                            <Vertex pos="-0.750001 0.433014 -0.499998" />
                            <Vertex pos="-0.866022 0 -0.500006" />
                            <Vertex pos="-0.75 -0.433018 -0.500001" />
                            <Vertex pos="-0.433013 -0.749996 -0.500009" />
                            <Vertex pos="6.91414e-006 -0.866028 -0.500002" />
                            <Vertex pos="0.433006 -0.749996 -0.500011" />
                            <Vertex pos="0.750005 -0.433006 -0.500001" />
                            <Vertex pos="0.866024 0.5 -2.92063e-006" />
                            <Vertex pos="0.999999 -3.8147e-006 -2.26498e-006" />
                            <Vertex pos="0.5 0.86602 -2.68221e-006" />
                            <Vertex pos="-1.90735e-006 0.999996 -1.78814e-006" />
                            <Vertex pos="-0.5 0.866024 1.03712e-005" />
                            <Vertex pos="-0.866019 0.500004 1.07288e-006" />
                            <Vertex pos="-0.999999 -3.8147e-006 -2.74181e-006" />
                            <Vertex pos="-0.866027 -0.499996 -2.38419e-006" />
                            <Vertex pos="-0.499998 -0.866028 8.70228e-006" />
                            <Vertex pos="-1.90735e-006 -0.999996 -5.06639e-006" />
                            <Vertex pos="0.500005 -0.866016 -7.86781e-006" />
                            <Vertex pos="0.866026 -0.499996 -6.97374e-006" />
                            <Vertex pos="0.749999 0.43301 0.5" />
                            <Vertex pos="0.866026 -3.8147e-006 0.499997" />
                            <Vertex pos="0.433007 0.750004 0.499995" />
                            <Vertex pos="-1.16825e-005 0.866028 0.499993" />
                            <Vertex pos="-0.433012 0.75 0.499996" />
                            <Vertex pos="-0.749995 0.433014 0.500003" />
                            <Vertex pos="-0.866022 0 0.500003" />
                            <Vertex pos="-0.75 -0.433014 0.499998" />
                            <Vertex pos="-0.433018 -0.749992 0.500002" />
                            <Vertex pos="-9.77516e-006 -0.86602 0.499996" />
                            <Vertex pos="0.433016 -0.749992 0.500014" />
                            <Vertex pos="0.750005 -0.433006 0.499996" />
                            <Vertex pos="0.433008 0.250008 0.866025" />
                            <Vertex pos="0.499997 0 0.866026" />
                            <Vertex pos="0.250006 0.433006 0.866023" />
                            <Vertex pos="1.43051e-006 0.499992 0.866026" />
                            <Vertex pos="-0.250002 0.433006 0.866025" />
                            <Vertex pos="-0.433011 0.249996 0.866027" />
                            <Vertex pos="-0.5 3.8147e-006 0.866024" />
                            <Vertex pos="-0.433009 -0.250008 0.866026" />
                            <Vertex pos="-0.250009 -0.43301 0.866023" />
                            <Vertex pos="1.16825e-005 -0.5 0.866025" />
                            <Vertex pos="0.249988 -0.433022 0.866023" />
                            <Vertex pos="0.433011 -0.249996 0.866026" />
                            <Vertex pos="-5.96046e-006 -7.62939e-006 0.999999" />
                        </Vertices>
                        <Face id="0" plane="0.258195 0.0691836 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 4.14121 -0.930778 -0.249401 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0.189012 0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 0.707108 0 4.14116 -0.681377 -0.681377 -0.267303 -8.55392 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 0 1" />
                        </Face>
                        <Face id="2" plane="0.0691877 0.258195 -0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258814 0 4.14116 -0.249397 -0.930779 -0.267303 -8.55395 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3" />
                        </Face>
                        <Face id="3" plane="-0.06918 0.258191 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 0.249405 -0.930777 -0.267304 -8.55394 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 0 4" />
                        </Face>
                        <Face id="4" plane="-0.189008 0.18901 -0.963614 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 4.14093 0.681377 -0.681377 -0.267303 -8.5539 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 5" />
                        </Face>
                        <Face id="5" plane="-0.258189 0.0691859 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 4.141 0.930778 -0.249404 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 0 6" />
                        </Face>
                        <Face id="6" plane="-0.258193 -0.0691777 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258818 -0.965926 0 4.141 0.930778 0.249401 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 8 0 7" />
                        </Face>
                        <Face id="7" plane="-0.189011 -0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707109 0 4.14098 0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 0 8" />
                        </Face>
                        <Face id="8" plane="-0.0691896 -0.258196 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 4.14106 0.249401 0.930778 -0.267303 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 10 0 9" />
                        </Face>
                        <Face id="9" plane="0.069185 -0.258198 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258823 0 4.14116 -0.249404 0.930777 -0.267304 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 0 10" />
                        </Face>
                        <Face id="10" plane="0.189012 -0.189017 -0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 4.14117 -0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 0 11" />
                        </Face>
                        <Face id="11" plane="0.258199 -0.0691766 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258814 0.965927 0 4.14121 -0.930779 0.249398 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 2 0" />
                        </Face>
                        <Face id="12" plane="0.694746 0.186155 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 -0.671074 -0.179813 -0.719255 -9.19553 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 14 13 1 2" />
                        </Face>
                        <Face id="13" plane="0.508593 0.508583 -0.694749 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 7.17272 -0.491259 -0.491261 -0.719255 -9.19557 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 3 1 13" />
                        </Face>
                        <Face id="14" plane="0.186185 0.694745 -0.69474 -0.949037" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17269 -0.179811 -0.671074 -0.719255 -9.1956 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 16 4 3 15" />
                        </Face>
                        <Face id="15" plane="-0.186176 0.694738 -0.69475 -0.949045" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 0.179816 -0.671074 -0.719254 -9.19558 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 5 4 16" />
                        </Face>
                        <Face id="16" plane="-0.508582 0.508602 -0.694743 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 0.491261 -0.491261 -0.719253 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 18 6 5 17" />
                        </Face>
                        <Face id="17" plane="-0.694746 0.186167 -0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17252 0.671074 -0.179816 -0.719254 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 7 6 18" />
                        </Face>
                        <Face id="18" plane="-0.694751 -0.186145 -0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 0.671074 0.179812 -0.719255 -9.19549 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 20 8 7 19" />
                        </Face>
                        <Face id="19" plane="-0.508598 -0.50858 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 7.17249 0.491261 0.49126 -0.719254 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 9 8 20" />
                        </Face>
                        <Face id="20" plane="-0.18617 -0.694745 -0.694745 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258817 0 7.17263 0.179813 0.671074 -0.719255 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 22 10 9 21" />
                        </Face>
                        <Face id="21" plane="0.186155 -0.694744 -0.69475 -0.949044" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 -0.179814 0.671074 -0.719254 -9.19542 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 11 10 22" />
                        </Face>
                        <Face id="22" plane="0.50859 -0.508588 -0.694747 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.707109 0 7.17273 -0.491262 0.491258 -0.719255 -9.19545 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 12 11 23" />
                        </Face>
                        <Face id="23" plane="0.694738 -0.186155 -0.694755 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17274 -0.671074 0.179811 -0.719255 -9.1955 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 14 2 12" />
                        </Face>
                        <Face id="24" plane="0.935113 0.250562 -0.250563 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28236 -0.242025 -0.0648507 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 26 25 13 14" />
                        </Face>
                        <Face id="25" plane="0.684533 0.684564 -0.25057 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 8.2823 -0.177175 -0.177175 -0.9681 -8.78248 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 15 13 25" />
                        </Face>
                        <Face id="26" plane="0.250583 0.935109 -0.250557 -0.935106" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28229 -0.0648499 -0.242027 -0.9681 -8.78245 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 28 16 15 27" />
                        </Face>
                        <Face id="27" plane="-0.25056 0.935116 -0.250554 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 0.0648515 -0.242025 -0.9681 -8.78249 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 17 16 28" />
                        </Face>
                        <Face id="28" plane="-0.684553 0.68455 -0.250557 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 0.177174 -0.177174 -0.968101 -8.78251 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 18 17 29" />
                        </Face>
                        <Face id="29" plane="-0.935114 0.250557 -0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28208 0.242025 -0.0648515 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 19 18 30" />
                        </Face>
                        <Face id="30" plane="-0.935116 -0.250555 -0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 0.242025 0.0648499 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 32 20 19 31" />
                        </Face>
                        <Face id="31" plane="-0.684544 -0.684557 -0.25056 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 0.177174 0.177174 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 33 21 20 32" />
                        </Face>
                        <Face id="32" plane="-0.250568 -0.935113 -0.250557 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.25882 0 8.28216 0.0648506 0.242025 -0.9681 -8.78243 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 34 22 21 33" />
                        </Face>
                        <Face id="33" plane="0.250578 -0.93511 -0.250559 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 -0.064851 0.242025 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 35 23 22 34" />
                        </Face>
                        <Face id="34" plane="0.684545 -0.684556 -0.250563 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 -0.177175 0.177174 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 24 23 35" />
                        </Face>
                        <Face id="35" plane="0.935114 -0.250561 -0.25056 -0.935115" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 -0.242025 0.0648494 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 26 14 24" />
                        </Face>
                        <Face id="36" plane="0.935113 0.250563 0.250562 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28235 0.242024 0.0648504 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 38 37 25 26" />
                        </Face>
                        <Face id="37" plane="0.684548 0.684554 0.25056 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 8.28229 0.177175 0.177175 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 39 27 25 37" />
                        </Face>
                        <Face id="38" plane="0.250565 0.935114 0.250559 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28228 0.0648496 0.242026 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 40 28 27 39" />
                        </Face>
                        <Face id="39" plane="-0.250554 0.935115 0.250567 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 -0.0648514 0.242025 -0.9681 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 41 29 28 40" />
                        </Face>
                        <Face id="40" plane="-0.684554 0.684546 0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 -0.177174 0.177174 -0.968101 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 42 30 29 41" />
                        </Face>
                        <Face id="41" plane="-0.935113 0.250566 0.250561 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28207 -0.242026 0.0648517 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 43 31 30 42" />
                        </Face>
                        <Face id="42" plane="-0.935113 -0.250561 0.250563 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 -0.242026 -0.0648501 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 44 32 31 43" />
                        </Face>
                        <Face id="43" plane="-0.684555 -0.684544 0.250569 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 -0.177174 -0.177174 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 45 33 32 44" />
                        </Face>
                        <Face id="44" plane="-0.250547 -0.935117 0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 8.28217 -0.0648506 -0.242026 -0.9681 -7.7449 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 46 34 33 45" />
                        </Face>
                        <Face id="45" plane="0.250571 -0.935114 0.250552 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 0.0648508 -0.242025 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 47 35 34 46" />
                        </Face>
                        <Face id="46" plane="0.68455 -0.684552 0.250559 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 0.177176 -0.177175 -0.9681 -7.74491 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 36 35 47" />
                        </Face>
                        <Face id="47" plane="0.935115 -0.25056 0.250561 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 0.242026 -0.0648496 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 38 26 36" />
                        </Face>
                        <Face id="48" plane="0.694747 0.186155 0.694747 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 0.671072 0.179812 -0.719257 -7.08919 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 50 49 37 38" />
                        </Face>
                        <Face id="49" plane="0.508588 0.508596 0.694744 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707108 0.707106 0 7.17272 0.491258 0.49126 -0.719256 -7.08917 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 51 39 37 49" />
                        </Face>
                        <Face id="50" plane="0.186149 0.694749 0.694747 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17268 0.17981 0.671072 -0.719257 -7.08913 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 52 40 39 51" />
                        </Face>
                        <Face id="51" plane="-0.186159 0.694743 0.69475 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 -0.179815 0.671072 -0.719256 -7.08915 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 53 41 40 52" />
                        </Face>
                        <Face id="52" plane="-0.508583 0.508594 0.694749 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 -0.491259 0.491259 -0.719257 -7.08918 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 54 42 41 53" />
                        </Face>
                        <Face id="53" plane="-0.694746 0.186158 0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17253 -0.671072 0.179815 -0.719256 -7.0892 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 55 43 42 54" />
                        </Face>
                        <Face id="54" plane="-0.694746 -0.186159 0.694747 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 -0.671072 -0.179812 -0.719257 -7.08923 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 56 44 43 55" />
                        </Face>
                        <Face id="55" plane="-0.508592 -0.508591 0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707108 0 7.17249 -0.49126 -0.491258 -0.719256 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 57 45 44 56" />
                        </Face>
                        <Face id="56" plane="-0.186154 -0.69475 0.694744 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 7.17262 -0.179812 -0.671072 -0.719257 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 58 46 45 57" />
                        </Face>
                        <Face id="57" plane="0.186129 -0.694755 0.694746 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 0.179814 -0.671072 -0.719256 -7.0893 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 59 47 46 58" />
                        </Face>
                        <Face id="58" plane="0.508605 -0.508572 0.694748 -0.949043" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 7.17272 0.49126 -0.491257 -0.719257 -7.08927 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 48 47 59" />
                        </Face>
                        <Face id="59" plane="0.694745 -0.186155 0.694748 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17273 0.671072 -0.179811 -0.719257 -7.08922 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 50 38 48" />
                        </Face>
                        <Face id="60" plane="0.258195 0.0691838 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258819 0.965926 0 4.1412 0.930779 0.249401 -0.267302 -7.48467 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 49 50" />
                        </Face>
                        <Face id="61" plane="0.189004 0.189019 0.963613 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 4.14117 0.681376 0.681376 -0.267306 -7.4845 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 51 49" />
                        </Face>
                        <Face id="62" plane="0.0691902 0.258196 0.963612 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 4.14115 0.249397 0.93078 -0.267302 -7.48458 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 52 51" />
                        </Face>
                        <Face id="63" plane="-0.069185 0.258198 0.963611 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 -0.249404 0.930778 -0.267302 -7.48459 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 53 52" />
                        </Face>
                        <Face id="64" plane="-0.18901 0.189019 0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707106 0 4.14093 -0.681377 0.681377 -0.267302 -7.48464 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 54 53" />
                        </Face>
                        <Face id="65" plane="-0.258201 0.069179 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 4.14099 -0.930778 0.249404 -0.267302 -7.48468 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 55 54" />
                        </Face>
                        <Face id="66" plane="-0.258204 -0.0691815 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258819 -0.965926 0 4.141 -0.930777 -0.249401 -0.267306 -7.48461 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 56 55" />
                        </Face>
                        <Face id="67" plane="-0.189012 -0.189023 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 4.14099 -0.681379 -0.681375 -0.267303 -7.48476 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 57 56" />
                        </Face>
                        <Face id="68" plane="-0.0691892 -0.258205 0.963609 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 4.14106 -0.249401 -0.930779 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 58 57" />
                        </Face>
                        <Face id="69" plane="0.0691877 -0.258201 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258822 0 4.14115 0.249404 -0.930778 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 59 58" />
                        </Face>
                        <Face id="70" plane="0.189011 -0.189022 0.963611 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.70711 0 4.14118 0.681378 -0.681374 -0.267306 -7.48465 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 60 59" />
                        </Face>
                        <Face id="71" plane="0.258197 -0.0691834 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 4.1412 0.930779 -0.249397 -0.267302 -7.48472 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 50 60" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="3 46.5 10" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 46.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="73" nextVertexID="63">
                        <Vertices>
                            <Vertex pos="5.00679e-006 -3.8147e-006 -0.999999" />
                            <Vertex pos="0.433012 0.249992 -0.866029" />
                            <Vertex pos="0.499995 1.14441e-005 -0.866028" />
                            <Vertex pos="0.25001 0.432999 -0.866028" />
                            <Vertex pos="-1.00136e-005 0.500004 -0.866026" />
                            <Vertex pos="-0.24999 0.43301 -0.86603" />
                            <Vertex pos="-0.43301 0.25 -0.866028" />
                            <Vertex pos="-0.499998 1.14441e-005 -0.866028" />
                            <Vertex pos="-0.433014 -0.249992 -0.866028" />
                            <Vertex pos="-0.250009 -0.433006 -0.866027" />
                            <Vertex pos="-1.90735e-006 -0.5 -0.866027" />
                            <Vertex pos="0.249998 -0.433014 -0.866026" />
                            <Vertex pos="0.433016 -0.249992 -0.866028" />
                            <Vertex pos="0.749996 0.433022 -0.500003" />
                            <Vertex pos="0.866025 -7.62939e-006 -0.500003" />
                            <Vertex pos="0.433015 0.749985 -0.500012" />
                            <Vertex pos="-1.19209e-006 0.866024 -0.500001" />
                            <Vertex pos="-0.433016 0.75 -0.499999" />
                            <Vertex pos="-0.750001 0.433014 -0.499998" />
                            <Vertex pos="-0.866022 0 -0.500006" />
                            <Vertex pos="-0.75 -0.433018 -0.500001" />
                            <Vertex pos="-0.433013 -0.749996 -0.500009" />
                            <Vertex pos="6.91414e-006 -0.866028 -0.500002" />
                            <Vertex pos="0.433006 -0.749996 -0.500011" />
                            <Vertex pos="0.750005 -0.433006 -0.500001" />
                            <Vertex pos="0.866024 0.5 -2.92063e-006" />
                            <Vertex pos="0.999999 -3.8147e-006 -2.26498e-006" />
                            <Vertex pos="0.5 0.86602 -2.68221e-006" />
                            <Vertex pos="-1.90735e-006 0.999996 -1.78814e-006" />
                            <Vertex pos="-0.5 0.866024 1.03712e-005" />
                            <Vertex pos="-0.866019 0.500004 1.07288e-006" />
                            <Vertex pos="-0.999999 -3.8147e-006 -2.74181e-006" />
                            <Vertex pos="-0.866027 -0.499996 -2.38419e-006" />
                            <Vertex pos="-0.499998 -0.866028 8.70228e-006" />
                            <Vertex pos="-1.90735e-006 -0.999996 -5.06639e-006" />
                            <Vertex pos="0.500005 -0.866016 -7.86781e-006" />
                            <Vertex pos="0.866026 -0.499996 -6.97374e-006" />
                            <Vertex pos="0.749999 0.43301 0.5" />
                            <Vertex pos="0.866026 -3.8147e-006 0.499997" />
                            <Vertex pos="0.433007 0.750004 0.499995" />
                            <Vertex pos="-1.16825e-005 0.866028 0.499993" />
                            <Vertex pos="-0.433012 0.75 0.499996" />
                            <Vertex pos="-0.749995 0.433014 0.500003" />
                            <Vertex pos="-0.866022 0 0.500003" />
                            <Vertex pos="-0.75 -0.433014 0.499998" />
                            <Vertex pos="-0.433018 -0.749992 0.500002" />
                            <Vertex pos="-9.77516e-006 -0.86602 0.499996" />
                            <Vertex pos="0.433016 -0.749992 0.500014" />
                            <Vertex pos="0.750005 -0.433006 0.499996" />
                            <Vertex pos="0.433008 0.250008 0.866025" />
                            <Vertex pos="0.499997 0 0.866026" />
                            <Vertex pos="0.250006 0.433006 0.866023" />
                            <Vertex pos="1.43051e-006 0.499992 0.866026" />
                            <Vertex pos="-0.250002 0.433006 0.866025" />
                            <Vertex pos="-0.433011 0.249996 0.866027" />
                            <Vertex pos="-0.5 3.8147e-006 0.866024" />
                            <Vertex pos="-0.433009 -0.250008 0.866026" />
                            <Vertex pos="-0.250009 -0.43301 0.866023" />
                            <Vertex pos="1.16825e-005 -0.5 0.866025" />
                            <Vertex pos="0.249988 -0.433022 0.866023" />
                            <Vertex pos="0.433011 -0.249996 0.866026" />
                            <Vertex pos="-5.96046e-006 -7.62939e-006 0.999999" />
                        </Vertices>
                        <Face id="0" plane="0.258195 0.0691836 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 4.14121 -0.930778 -0.249401 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0.189012 0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 0.707108 0 4.14116 -0.681377 -0.681377 -0.267303 -8.55392 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 0 1" />
                        </Face>
                        <Face id="2" plane="0.0691877 0.258195 -0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258814 0 4.14116 -0.249397 -0.930779 -0.267303 -8.55395 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3" />
                        </Face>
                        <Face id="3" plane="-0.06918 0.258191 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 0.249405 -0.930777 -0.267304 -8.55394 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 0 4" />
                        </Face>
                        <Face id="4" plane="-0.189008 0.18901 -0.963614 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 4.14093 0.681377 -0.681377 -0.267303 -8.5539 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 5" />
                        </Face>
                        <Face id="5" plane="-0.258189 0.0691859 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 4.141 0.930778 -0.249404 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 0 6" />
                        </Face>
                        <Face id="6" plane="-0.258193 -0.0691777 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258818 -0.965926 0 4.141 0.930778 0.249401 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 8 0 7" />
                        </Face>
                        <Face id="7" plane="-0.189011 -0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707109 0 4.14098 0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 0 8" />
                        </Face>
                        <Face id="8" plane="-0.0691896 -0.258196 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 4.14106 0.249401 0.930778 -0.267303 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 10 0 9" />
                        </Face>
                        <Face id="9" plane="0.069185 -0.258198 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258823 0 4.14116 -0.249404 0.930777 -0.267304 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 0 10" />
                        </Face>
                        <Face id="10" plane="0.189012 -0.189017 -0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 4.14117 -0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 0 11" />
                        </Face>
                        <Face id="11" plane="0.258199 -0.0691766 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258814 0.965927 0 4.14121 -0.930779 0.249398 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 2 0" />
                        </Face>
                        <Face id="12" plane="0.694746 0.186155 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 -0.671074 -0.179813 -0.719255 -9.19553 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 14 13 1 2" />
                        </Face>
                        <Face id="13" plane="0.508593 0.508583 -0.694749 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 7.17272 -0.491259 -0.491261 -0.719255 -9.19557 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 3 1 13" />
                        </Face>
                        <Face id="14" plane="0.186185 0.694745 -0.69474 -0.949037" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17269 -0.179811 -0.671074 -0.719255 -9.1956 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 16 4 3 15" />
                        </Face>
                        <Face id="15" plane="-0.186176 0.694738 -0.69475 -0.949045" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 0.179816 -0.671074 -0.719254 -9.19558 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 5 4 16" />
                        </Face>
                        <Face id="16" plane="-0.508582 0.508602 -0.694743 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 0.491261 -0.491261 -0.719253 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 18 6 5 17" />
                        </Face>
                        <Face id="17" plane="-0.694746 0.186167 -0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17252 0.671074 -0.179816 -0.719254 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 7 6 18" />
                        </Face>
                        <Face id="18" plane="-0.694751 -0.186145 -0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 0.671074 0.179812 -0.719255 -9.19549 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 20 8 7 19" />
                        </Face>
                        <Face id="19" plane="-0.508598 -0.50858 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 7.17249 0.491261 0.49126 -0.719254 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 9 8 20" />
                        </Face>
                        <Face id="20" plane="-0.18617 -0.694745 -0.694745 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258817 0 7.17263 0.179813 0.671074 -0.719255 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 22 10 9 21" />
                        </Face>
                        <Face id="21" plane="0.186155 -0.694744 -0.69475 -0.949044" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 -0.179814 0.671074 -0.719254 -9.19542 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 11 10 22" />
                        </Face>
                        <Face id="22" plane="0.50859 -0.508588 -0.694747 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.707109 0 7.17273 -0.491262 0.491258 -0.719255 -9.19545 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 12 11 23" />
                        </Face>
                        <Face id="23" plane="0.694738 -0.186155 -0.694755 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17274 -0.671074 0.179811 -0.719255 -9.1955 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 14 2 12" />
                        </Face>
                        <Face id="24" plane="0.935113 0.250562 -0.250563 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28236 -0.242025 -0.0648507 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 26 25 13 14" />
                        </Face>
                        <Face id="25" plane="0.684533 0.684564 -0.25057 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 8.2823 -0.177175 -0.177175 -0.9681 -8.78248 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 15 13 25" />
                        </Face>
                        <Face id="26" plane="0.250583 0.935109 -0.250557 -0.935106" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28229 -0.0648499 -0.242027 -0.9681 -8.78245 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 28 16 15 27" />
                        </Face>
                        <Face id="27" plane="-0.25056 0.935116 -0.250554 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 0.0648515 -0.242025 -0.9681 -8.78249 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 17 16 28" />
                        </Face>
                        <Face id="28" plane="-0.684553 0.68455 -0.250557 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 0.177174 -0.177174 -0.968101 -8.78251 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 18 17 29" />
                        </Face>
                        <Face id="29" plane="-0.935114 0.250557 -0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28208 0.242025 -0.0648515 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 19 18 30" />
                        </Face>
                        <Face id="30" plane="-0.935116 -0.250555 -0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 0.242025 0.0648499 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 32 20 19 31" />
                        </Face>
                        <Face id="31" plane="-0.684544 -0.684557 -0.25056 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 0.177174 0.177174 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 33 21 20 32" />
                        </Face>
                        <Face id="32" plane="-0.250568 -0.935113 -0.250557 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.25882 0 8.28216 0.0648506 0.242025 -0.9681 -8.78243 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 34 22 21 33" />
                        </Face>
                        <Face id="33" plane="0.250578 -0.93511 -0.250559 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 -0.064851 0.242025 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 35 23 22 34" />
                        </Face>
                        <Face id="34" plane="0.684545 -0.684556 -0.250563 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 -0.177175 0.177174 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 24 23 35" />
                        </Face>
                        <Face id="35" plane="0.935114 -0.250561 -0.25056 -0.935115" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 -0.242025 0.0648494 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 26 14 24" />
                        </Face>
                        <Face id="36" plane="0.935113 0.250563 0.250562 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28235 0.242024 0.0648504 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 38 37 25 26" />
                        </Face>
                        <Face id="37" plane="0.684548 0.684554 0.25056 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 8.28229 0.177175 0.177175 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 39 27 25 37" />
                        </Face>
                        <Face id="38" plane="0.250565 0.935114 0.250559 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28228 0.0648496 0.242026 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 40 28 27 39" />
                        </Face>
                        <Face id="39" plane="-0.250554 0.935115 0.250567 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 -0.0648514 0.242025 -0.9681 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 41 29 28 40" />
                        </Face>
                        <Face id="40" plane="-0.684554 0.684546 0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 -0.177174 0.177174 -0.968101 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 42 30 29 41" />
                        </Face>
                        <Face id="41" plane="-0.935113 0.250566 0.250561 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28207 -0.242026 0.0648517 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 43 31 30 42" />
                        </Face>
                        <Face id="42" plane="-0.935113 -0.250561 0.250563 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 -0.242026 -0.0648501 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 44 32 31 43" />
                        </Face>
                        <Face id="43" plane="-0.684555 -0.684544 0.250569 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 -0.177174 -0.177174 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 45 33 32 44" />
                        </Face>
                        <Face id="44" plane="-0.250547 -0.935117 0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 8.28217 -0.0648506 -0.242026 -0.9681 -7.7449 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 46 34 33 45" />
                        </Face>
                        <Face id="45" plane="0.250571 -0.935114 0.250552 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 0.0648508 -0.242025 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 47 35 34 46" />
                        </Face>
                        <Face id="46" plane="0.68455 -0.684552 0.250559 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 0.177176 -0.177175 -0.9681 -7.74491 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 36 35 47" />
                        </Face>
                        <Face id="47" plane="0.935115 -0.25056 0.250561 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 0.242026 -0.0648496 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 38 26 36" />
                        </Face>
                        <Face id="48" plane="0.694747 0.186155 0.694747 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 0.671072 0.179812 -0.719257 -7.08919 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 50 49 37 38" />
                        </Face>
                        <Face id="49" plane="0.508588 0.508596 0.694744 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707108 0.707106 0 7.17272 0.491258 0.49126 -0.719256 -7.08917 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 51 39 37 49" />
                        </Face>
                        <Face id="50" plane="0.186149 0.694749 0.694747 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17268 0.17981 0.671072 -0.719257 -7.08913 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 52 40 39 51" />
                        </Face>
                        <Face id="51" plane="-0.186159 0.694743 0.69475 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 -0.179815 0.671072 -0.719256 -7.08915 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 53 41 40 52" />
                        </Face>
                        <Face id="52" plane="-0.508583 0.508594 0.694749 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 -0.491259 0.491259 -0.719257 -7.08918 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 54 42 41 53" />
                        </Face>
                        <Face id="53" plane="-0.694746 0.186158 0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17253 -0.671072 0.179815 -0.719256 -7.0892 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 55 43 42 54" />
                        </Face>
                        <Face id="54" plane="-0.694746 -0.186159 0.694747 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 -0.671072 -0.179812 -0.719257 -7.08923 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 56 44 43 55" />
                        </Face>
                        <Face id="55" plane="-0.508592 -0.508591 0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707108 0 7.17249 -0.49126 -0.491258 -0.719256 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 57 45 44 56" />
                        </Face>
                        <Face id="56" plane="-0.186154 -0.69475 0.694744 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 7.17262 -0.179812 -0.671072 -0.719257 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 58 46 45 57" />
                        </Face>
                        <Face id="57" plane="0.186129 -0.694755 0.694746 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 0.179814 -0.671072 -0.719256 -7.0893 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 59 47 46 58" />
                        </Face>
                        <Face id="58" plane="0.508605 -0.508572 0.694748 -0.949043" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 7.17272 0.49126 -0.491257 -0.719257 -7.08927 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 48 47 59" />
                        </Face>
                        <Face id="59" plane="0.694745 -0.186155 0.694748 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17273 0.671072 -0.179811 -0.719257 -7.08922 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 50 38 48" />
                        </Face>
                        <Face id="60" plane="0.258195 0.0691838 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258819 0.965926 0 4.1412 0.930779 0.249401 -0.267302 -7.48467 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 49 50" />
                        </Face>
                        <Face id="61" plane="0.189004 0.189019 0.963613 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 4.14117 0.681376 0.681376 -0.267306 -7.4845 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 51 49" />
                        </Face>
                        <Face id="62" plane="0.0691902 0.258196 0.963612 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 4.14115 0.249397 0.93078 -0.267302 -7.48458 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 52 51" />
                        </Face>
                        <Face id="63" plane="-0.069185 0.258198 0.963611 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 -0.249404 0.930778 -0.267302 -7.48459 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 53 52" />
                        </Face>
                        <Face id="64" plane="-0.18901 0.189019 0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707106 0 4.14093 -0.681377 0.681377 -0.267302 -7.48464 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 54 53" />
                        </Face>
                        <Face id="65" plane="-0.258201 0.069179 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 4.14099 -0.930778 0.249404 -0.267302 -7.48468 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 55 54" />
                        </Face>
                        <Face id="66" plane="-0.258204 -0.0691815 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258819 -0.965926 0 4.141 -0.930777 -0.249401 -0.267306 -7.48461 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 56 55" />
                        </Face>
                        <Face id="67" plane="-0.189012 -0.189023 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 4.14099 -0.681379 -0.681375 -0.267303 -7.48476 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 57 56" />
                        </Face>
                        <Face id="68" plane="-0.0691892 -0.258205 0.963609 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 4.14106 -0.249401 -0.930779 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 58 57" />
                        </Face>
                        <Face id="69" plane="0.0691877 -0.258201 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258822 0 4.14115 0.249404 -0.930778 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 59 58" />
                        </Face>
                        <Face id="70" plane="0.189011 -0.189022 0.963611 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.70711 0 4.14118 0.681378 -0.681374 -0.267306 -7.48465 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 60 59" />
                        </Face>
                        <Face id="71" plane="0.258197 -0.0691834 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 4.1412 0.930779 -0.249397 -0.267302 -7.48472 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 50 60" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="3 49.5 10" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 49.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="73" nextVertexID="63">
                        <Vertices>
                            <Vertex pos="5.00679e-006 -3.8147e-006 -0.999999" />
                            <Vertex pos="0.433012 0.249992 -0.866029" />
                            <Vertex pos="0.499995 1.14441e-005 -0.866028" />
                            <Vertex pos="0.25001 0.432999 -0.866028" />
                            <Vertex pos="-1.00136e-005 0.500004 -0.866026" />
                            <Vertex pos="-0.24999 0.43301 -0.86603" />
                            <Vertex pos="-0.43301 0.25 -0.866028" />
                            <Vertex pos="-0.499998 1.14441e-005 -0.866028" />
                            <Vertex pos="-0.433014 -0.249992 -0.866028" />
                            <Vertex pos="-0.250009 -0.433006 -0.866027" />
                            <Vertex pos="-1.90735e-006 -0.5 -0.866027" />
                            <Vertex pos="0.249998 -0.433014 -0.866026" />
                            <Vertex pos="0.433016 -0.249992 -0.866028" />
                            <Vertex pos="0.749996 0.433022 -0.500003" />
                            <Vertex pos="0.866025 -7.62939e-006 -0.500003" />
                            <Vertex pos="0.433015 0.749985 -0.500012" />
                            <Vertex pos="-1.19209e-006 0.866024 -0.500001" />
                            <Vertex pos="-0.433016 0.75 -0.499999" />
                            <Vertex pos="-0.750001 0.433014 -0.499998" />
                            <Vertex pos="-0.866022 0 -0.500006" />
                            <Vertex pos="-0.75 -0.433018 -0.500001" />
                            <Vertex pos="-0.433013 -0.749996 -0.500009" />
                            <Vertex pos="6.91414e-006 -0.866028 -0.500002" />
                            <Vertex pos="0.433006 -0.749996 -0.500011" />
                            <Vertex pos="0.750005 -0.433006 -0.500001" />
                            <Vertex pos="0.866024 0.5 -2.92063e-006" />
                            <Vertex pos="0.999999 -3.8147e-006 -2.26498e-006" />
                            <Vertex pos="0.5 0.86602 -2.68221e-006" />
                            <Vertex pos="-1.90735e-006 0.999996 -1.78814e-006" />
                            <Vertex pos="-0.5 0.866024 1.03712e-005" />
                            <Vertex pos="-0.866019 0.500004 1.07288e-006" />
                            <Vertex pos="-0.999999 -3.8147e-006 -2.74181e-006" />
                            <Vertex pos="-0.866027 -0.499996 -2.38419e-006" />
                            <Vertex pos="-0.499998 -0.866028 8.70228e-006" />
                            <Vertex pos="-1.90735e-006 -0.999996 -5.06639e-006" />
                            <Vertex pos="0.500005 -0.866016 -7.86781e-006" />
                            <Vertex pos="0.866026 -0.499996 -6.97374e-006" />
                            <Vertex pos="0.749999 0.43301 0.5" />
                            <Vertex pos="0.866026 -3.8147e-006 0.499997" />
                            <Vertex pos="0.433007 0.750004 0.499995" />
                            <Vertex pos="-1.16825e-005 0.866028 0.499993" />
                            <Vertex pos="-0.433012 0.75 0.499996" />
                            <Vertex pos="-0.749995 0.433014 0.500003" />
                            <Vertex pos="-0.866022 0 0.500003" />
                            <Vertex pos="-0.75 -0.433014 0.499998" />
                            <Vertex pos="-0.433018 -0.749992 0.500002" />
                            <Vertex pos="-9.77516e-006 -0.86602 0.499996" />
                            <Vertex pos="0.433016 -0.749992 0.500014" />
                            <Vertex pos="0.750005 -0.433006 0.499996" />
                            <Vertex pos="0.433008 0.250008 0.866025" />
                            <Vertex pos="0.499997 0 0.866026" />
                            <Vertex pos="0.250006 0.433006 0.866023" />
                            <Vertex pos="1.43051e-006 0.499992 0.866026" />
                            <Vertex pos="-0.250002 0.433006 0.866025" />
                            <Vertex pos="-0.433011 0.249996 0.866027" />
                            <Vertex pos="-0.5 3.8147e-006 0.866024" />
                            <Vertex pos="-0.433009 -0.250008 0.866026" />
                            <Vertex pos="-0.250009 -0.43301 0.866023" />
                            <Vertex pos="1.16825e-005 -0.5 0.866025" />
                            <Vertex pos="0.249988 -0.433022 0.866023" />
                            <Vertex pos="0.433011 -0.249996 0.866026" />
                            <Vertex pos="-5.96046e-006 -7.62939e-006 0.999999" />
                        </Vertices>
                        <Face id="0" plane="0.258195 0.0691836 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 4.14121 -0.930778 -0.249401 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0.189012 0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 0.707108 0 4.14116 -0.681377 -0.681377 -0.267303 -8.55392 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 0 1" />
                        </Face>
                        <Face id="2" plane="0.0691877 0.258195 -0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258814 0 4.14116 -0.249397 -0.930779 -0.267303 -8.55395 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3" />
                        </Face>
                        <Face id="3" plane="-0.06918 0.258191 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 0.249405 -0.930777 -0.267304 -8.55394 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 0 4" />
                        </Face>
                        <Face id="4" plane="-0.189008 0.18901 -0.963614 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 4.14093 0.681377 -0.681377 -0.267303 -8.5539 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 5" />
                        </Face>
                        <Face id="5" plane="-0.258189 0.0691859 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 4.141 0.930778 -0.249404 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 0 6" />
                        </Face>
                        <Face id="6" plane="-0.258193 -0.0691777 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258818 -0.965926 0 4.141 0.930778 0.249401 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 8 0 7" />
                        </Face>
                        <Face id="7" plane="-0.189011 -0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707109 0 4.14098 0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 0 8" />
                        </Face>
                        <Face id="8" plane="-0.0691896 -0.258196 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 4.14106 0.249401 0.930778 -0.267303 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 10 0 9" />
                        </Face>
                        <Face id="9" plane="0.069185 -0.258198 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258823 0 4.14116 -0.249404 0.930777 -0.267304 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 0 10" />
                        </Face>
                        <Face id="10" plane="0.189012 -0.189017 -0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 4.14117 -0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 0 11" />
                        </Face>
                        <Face id="11" plane="0.258199 -0.0691766 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258814 0.965927 0 4.14121 -0.930779 0.249398 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 2 0" />
                        </Face>
                        <Face id="12" plane="0.694746 0.186155 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 -0.671074 -0.179813 -0.719255 -9.19553 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 14 13 1 2" />
                        </Face>
                        <Face id="13" plane="0.508593 0.508583 -0.694749 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 7.17272 -0.491259 -0.491261 -0.719255 -9.19557 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 3 1 13" />
                        </Face>
                        <Face id="14" plane="0.186185 0.694745 -0.69474 -0.949037" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17269 -0.179811 -0.671074 -0.719255 -9.1956 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 16 4 3 15" />
                        </Face>
                        <Face id="15" plane="-0.186176 0.694738 -0.69475 -0.949045" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 0.179816 -0.671074 -0.719254 -9.19558 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 5 4 16" />
                        </Face>
                        <Face id="16" plane="-0.508582 0.508602 -0.694743 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 0.491261 -0.491261 -0.719253 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 18 6 5 17" />
                        </Face>
                        <Face id="17" plane="-0.694746 0.186167 -0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17252 0.671074 -0.179816 -0.719254 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 7 6 18" />
                        </Face>
                        <Face id="18" plane="-0.694751 -0.186145 -0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 0.671074 0.179812 -0.719255 -9.19549 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 20 8 7 19" />
                        </Face>
                        <Face id="19" plane="-0.508598 -0.50858 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 7.17249 0.491261 0.49126 -0.719254 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 9 8 20" />
                        </Face>
                        <Face id="20" plane="-0.18617 -0.694745 -0.694745 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258817 0 7.17263 0.179813 0.671074 -0.719255 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 22 10 9 21" />
                        </Face>
                        <Face id="21" plane="0.186155 -0.694744 -0.69475 -0.949044" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 -0.179814 0.671074 -0.719254 -9.19542 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 11 10 22" />
                        </Face>
                        <Face id="22" plane="0.50859 -0.508588 -0.694747 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.707109 0 7.17273 -0.491262 0.491258 -0.719255 -9.19545 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 12 11 23" />
                        </Face>
                        <Face id="23" plane="0.694738 -0.186155 -0.694755 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17274 -0.671074 0.179811 -0.719255 -9.1955 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 14 2 12" />
                        </Face>
                        <Face id="24" plane="0.935113 0.250562 -0.250563 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28236 -0.242025 -0.0648507 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 26 25 13 14" />
                        </Face>
                        <Face id="25" plane="0.684533 0.684564 -0.25057 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 8.2823 -0.177175 -0.177175 -0.9681 -8.78248 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 15 13 25" />
                        </Face>
                        <Face id="26" plane="0.250583 0.935109 -0.250557 -0.935106" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28229 -0.0648499 -0.242027 -0.9681 -8.78245 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 28 16 15 27" />
                        </Face>
                        <Face id="27" plane="-0.25056 0.935116 -0.250554 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 0.0648515 -0.242025 -0.9681 -8.78249 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 17 16 28" />
                        </Face>
                        <Face id="28" plane="-0.684553 0.68455 -0.250557 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 0.177174 -0.177174 -0.968101 -8.78251 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 18 17 29" />
                        </Face>
                        <Face id="29" plane="-0.935114 0.250557 -0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28208 0.242025 -0.0648515 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 19 18 30" />
                        </Face>
                        <Face id="30" plane="-0.935116 -0.250555 -0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 0.242025 0.0648499 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 32 20 19 31" />
                        </Face>
                        <Face id="31" plane="-0.684544 -0.684557 -0.25056 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 0.177174 0.177174 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 33 21 20 32" />
                        </Face>
                        <Face id="32" plane="-0.250568 -0.935113 -0.250557 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.25882 0 8.28216 0.0648506 0.242025 -0.9681 -8.78243 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 34 22 21 33" />
                        </Face>
                        <Face id="33" plane="0.250578 -0.93511 -0.250559 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 -0.064851 0.242025 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 35 23 22 34" />
                        </Face>
                        <Face id="34" plane="0.684545 -0.684556 -0.250563 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 -0.177175 0.177174 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 24 23 35" />
                        </Face>
                        <Face id="35" plane="0.935114 -0.250561 -0.25056 -0.935115" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 -0.242025 0.0648494 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 26 14 24" />
                        </Face>
                        <Face id="36" plane="0.935113 0.250563 0.250562 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28235 0.242024 0.0648504 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 38 37 25 26" />
                        </Face>
                        <Face id="37" plane="0.684548 0.684554 0.25056 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 8.28229 0.177175 0.177175 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 39 27 25 37" />
                        </Face>
                        <Face id="38" plane="0.250565 0.935114 0.250559 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28228 0.0648496 0.242026 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 40 28 27 39" />
                        </Face>
                        <Face id="39" plane="-0.250554 0.935115 0.250567 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 -0.0648514 0.242025 -0.9681 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 41 29 28 40" />
                        </Face>
                        <Face id="40" plane="-0.684554 0.684546 0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 -0.177174 0.177174 -0.968101 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 42 30 29 41" />
                        </Face>
                        <Face id="41" plane="-0.935113 0.250566 0.250561 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28207 -0.242026 0.0648517 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 43 31 30 42" />
                        </Face>
                        <Face id="42" plane="-0.935113 -0.250561 0.250563 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 -0.242026 -0.0648501 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 44 32 31 43" />
                        </Face>
                        <Face id="43" plane="-0.684555 -0.684544 0.250569 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 -0.177174 -0.177174 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 45 33 32 44" />
                        </Face>
                        <Face id="44" plane="-0.250547 -0.935117 0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 8.28217 -0.0648506 -0.242026 -0.9681 -7.7449 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 46 34 33 45" />
                        </Face>
                        <Face id="45" plane="0.250571 -0.935114 0.250552 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 0.0648508 -0.242025 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 47 35 34 46" />
                        </Face>
                        <Face id="46" plane="0.68455 -0.684552 0.250559 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 0.177176 -0.177175 -0.9681 -7.74491 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 36 35 47" />
                        </Face>
                        <Face id="47" plane="0.935115 -0.25056 0.250561 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 0.242026 -0.0648496 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 38 26 36" />
                        </Face>
                        <Face id="48" plane="0.694747 0.186155 0.694747 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 0.671072 0.179812 -0.719257 -7.08919 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 50 49 37 38" />
                        </Face>
                        <Face id="49" plane="0.508588 0.508596 0.694744 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707108 0.707106 0 7.17272 0.491258 0.49126 -0.719256 -7.08917 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 51 39 37 49" />
                        </Face>
                        <Face id="50" plane="0.186149 0.694749 0.694747 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17268 0.17981 0.671072 -0.719257 -7.08913 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 52 40 39 51" />
                        </Face>
                        <Face id="51" plane="-0.186159 0.694743 0.69475 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 -0.179815 0.671072 -0.719256 -7.08915 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 53 41 40 52" />
                        </Face>
                        <Face id="52" plane="-0.508583 0.508594 0.694749 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 -0.491259 0.491259 -0.719257 -7.08918 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 54 42 41 53" />
                        </Face>
                        <Face id="53" plane="-0.694746 0.186158 0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17253 -0.671072 0.179815 -0.719256 -7.0892 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 55 43 42 54" />
                        </Face>
                        <Face id="54" plane="-0.694746 -0.186159 0.694747 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 -0.671072 -0.179812 -0.719257 -7.08923 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 56 44 43 55" />
                        </Face>
                        <Face id="55" plane="-0.508592 -0.508591 0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707108 0 7.17249 -0.49126 -0.491258 -0.719256 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 57 45 44 56" />
                        </Face>
                        <Face id="56" plane="-0.186154 -0.69475 0.694744 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 7.17262 -0.179812 -0.671072 -0.719257 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 58 46 45 57" />
                        </Face>
                        <Face id="57" plane="0.186129 -0.694755 0.694746 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 0.179814 -0.671072 -0.719256 -7.0893 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 59 47 46 58" />
                        </Face>
                        <Face id="58" plane="0.508605 -0.508572 0.694748 -0.949043" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 7.17272 0.49126 -0.491257 -0.719257 -7.08927 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 48 47 59" />
                        </Face>
                        <Face id="59" plane="0.694745 -0.186155 0.694748 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17273 0.671072 -0.179811 -0.719257 -7.08922 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 50 38 48" />
                        </Face>
                        <Face id="60" plane="0.258195 0.0691838 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258819 0.965926 0 4.1412 0.930779 0.249401 -0.267302 -7.48467 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 49 50" />
                        </Face>
                        <Face id="61" plane="0.189004 0.189019 0.963613 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 4.14117 0.681376 0.681376 -0.267306 -7.4845 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 51 49" />
                        </Face>
                        <Face id="62" plane="0.0691902 0.258196 0.963612 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 4.14115 0.249397 0.93078 -0.267302 -7.48458 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 52 51" />
                        </Face>
                        <Face id="63" plane="-0.069185 0.258198 0.963611 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 -0.249404 0.930778 -0.267302 -7.48459 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 53 52" />
                        </Face>
                        <Face id="64" plane="-0.18901 0.189019 0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707106 0 4.14093 -0.681377 0.681377 -0.267302 -7.48464 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 54 53" />
                        </Face>
                        <Face id="65" plane="-0.258201 0.069179 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 4.14099 -0.930778 0.249404 -0.267302 -7.48468 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 55 54" />
                        </Face>
                        <Face id="66" plane="-0.258204 -0.0691815 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258819 -0.965926 0 4.141 -0.930777 -0.249401 -0.267306 -7.48461 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 56 55" />
                        </Face>
                        <Face id="67" plane="-0.189012 -0.189023 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 4.14099 -0.681379 -0.681375 -0.267303 -7.48476 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 57 56" />
                        </Face>
                        <Face id="68" plane="-0.0691892 -0.258205 0.963609 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 4.14106 -0.249401 -0.930779 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 58 57" />
                        </Face>
                        <Face id="69" plane="0.0691877 -0.258201 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258822 0 4.14115 0.249404 -0.930778 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 59 58" />
                        </Face>
                        <Face id="70" plane="0.189011 -0.189022 0.963611 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.70711 0 4.14118 0.681378 -0.681374 -0.267306 -7.48465 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 60 59" />
                        </Face>
                        <Face id="71" plane="0.258197 -0.0691834 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 4.1412 0.930779 -0.249397 -0.267302 -7.48472 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 50 60" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="3 52.5 10" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 52.5 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="73" nextVertexID="63">
                        <Vertices>
                            <Vertex pos="5.00679e-006 -3.8147e-006 -0.999999" />
                            <Vertex pos="0.433012 0.249992 -0.866029" />
                            <Vertex pos="0.499995 1.14441e-005 -0.866028" />
                            <Vertex pos="0.25001 0.432999 -0.866028" />
                            <Vertex pos="-1.00136e-005 0.500004 -0.866026" />
                            <Vertex pos="-0.24999 0.43301 -0.86603" />
                            <Vertex pos="-0.43301 0.25 -0.866028" />
                            <Vertex pos="-0.499998 1.14441e-005 -0.866028" />
                            <Vertex pos="-0.433014 -0.249992 -0.866028" />
                            <Vertex pos="-0.250009 -0.433006 -0.866027" />
                            <Vertex pos="-1.90735e-006 -0.5 -0.866027" />
                            <Vertex pos="0.249998 -0.433014 -0.866026" />
                            <Vertex pos="0.433016 -0.249992 -0.866028" />
                            <Vertex pos="0.749996 0.433022 -0.500003" />
                            <Vertex pos="0.866025 -7.62939e-006 -0.500003" />
                            <Vertex pos="0.433015 0.749985 -0.500012" />
                            <Vertex pos="-1.19209e-006 0.866024 -0.500001" />
                            <Vertex pos="-0.433016 0.75 -0.499999" />
                            <Vertex pos="-0.750001 0.433014 -0.499998" />
                            <Vertex pos="-0.866022 0 -0.500006" />
                            <Vertex pos="-0.75 -0.433018 -0.500001" />
                            <Vertex pos="-0.433013 -0.749996 -0.500009" />
                            <Vertex pos="6.91414e-006 -0.866028 -0.500002" />
                            <Vertex pos="0.433006 -0.749996 -0.500011" />
                            <Vertex pos="0.750005 -0.433006 -0.500001" />
                            <Vertex pos="0.866024 0.5 -2.92063e-006" />
                            <Vertex pos="0.999999 -3.8147e-006 -2.26498e-006" />
                            <Vertex pos="0.5 0.86602 -2.68221e-006" />
                            <Vertex pos="-1.90735e-006 0.999996 -1.78814e-006" />
                            <Vertex pos="-0.5 0.866024 1.03712e-005" />
                            <Vertex pos="-0.866019 0.500004 1.07288e-006" />
                            <Vertex pos="-0.999999 -3.8147e-006 -2.74181e-006" />
                            <Vertex pos="-0.866027 -0.499996 -2.38419e-006" />
                            <Vertex pos="-0.499998 -0.866028 8.70228e-006" />
                            <Vertex pos="-1.90735e-006 -0.999996 -5.06639e-006" />
                            <Vertex pos="0.500005 -0.866016 -7.86781e-006" />
                            <Vertex pos="0.866026 -0.499996 -6.97374e-006" />
                            <Vertex pos="0.749999 0.43301 0.5" />
                            <Vertex pos="0.866026 -3.8147e-006 0.499997" />
                            <Vertex pos="0.433007 0.750004 0.499995" />
                            <Vertex pos="-1.16825e-005 0.866028 0.499993" />
                            <Vertex pos="-0.433012 0.75 0.499996" />
                            <Vertex pos="-0.749995 0.433014 0.500003" />
                            <Vertex pos="-0.866022 0 0.500003" />
                            <Vertex pos="-0.75 -0.433014 0.499998" />
                            <Vertex pos="-0.433018 -0.749992 0.500002" />
                            <Vertex pos="-9.77516e-006 -0.86602 0.499996" />
                            <Vertex pos="0.433016 -0.749992 0.500014" />
                            <Vertex pos="0.750005 -0.433006 0.499996" />
                            <Vertex pos="0.433008 0.250008 0.866025" />
                            <Vertex pos="0.499997 0 0.866026" />
                            <Vertex pos="0.250006 0.433006 0.866023" />
                            <Vertex pos="1.43051e-006 0.499992 0.866026" />
                            <Vertex pos="-0.250002 0.433006 0.866025" />
                            <Vertex pos="-0.433011 0.249996 0.866027" />
                            <Vertex pos="-0.5 3.8147e-006 0.866024" />
                            <Vertex pos="-0.433009 -0.250008 0.866026" />
                            <Vertex pos="-0.250009 -0.43301 0.866023" />
                            <Vertex pos="1.16825e-005 -0.5 0.866025" />
                            <Vertex pos="0.249988 -0.433022 0.866023" />
                            <Vertex pos="0.433011 -0.249996 0.866026" />
                            <Vertex pos="-5.96046e-006 -7.62939e-006 0.999999" />
                        </Vertices>
                        <Face id="0" plane="0.258195 0.0691836 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 4.14121 -0.930778 -0.249401 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0.189012 0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 0.707108 0 4.14116 -0.681377 -0.681377 -0.267303 -8.55392 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 0 1" />
                        </Face>
                        <Face id="2" plane="0.0691877 0.258195 -0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258814 0 4.14116 -0.249397 -0.930779 -0.267303 -8.55395 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3" />
                        </Face>
                        <Face id="3" plane="-0.06918 0.258191 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 0.249405 -0.930777 -0.267304 -8.55394 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 0 4" />
                        </Face>
                        <Face id="4" plane="-0.189008 0.18901 -0.963614 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 4.14093 0.681377 -0.681377 -0.267303 -8.5539 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 5" />
                        </Face>
                        <Face id="5" plane="-0.258189 0.0691859 -0.963614 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 4.141 0.930778 -0.249404 -0.267303 -8.55387 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 0 6" />
                        </Face>
                        <Face id="6" plane="-0.258193 -0.0691777 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258818 -0.965926 0 4.141 0.930778 0.249401 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 8 0 7" />
                        </Face>
                        <Face id="7" plane="-0.189011 -0.189012 -0.963613 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707109 0 4.14098 0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 9 0 8" />
                        </Face>
                        <Face id="8" plane="-0.0691896 -0.258196 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 4.14106 0.249401 0.930778 -0.267303 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 10 0 9" />
                        </Face>
                        <Face id="9" plane="0.069185 -0.258198 -0.963612 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258823 0 4.14116 -0.249404 0.930777 -0.267304 -8.55372 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 11 0 10" />
                        </Face>
                        <Face id="10" plane="0.189012 -0.189017 -0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 4.14117 -0.681379 0.681375 -0.267304 -8.55375 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 0 11" />
                        </Face>
                        <Face id="11" plane="0.258199 -0.0691766 -0.963612 -0.963613" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258814 0.965927 0 4.14121 -0.930779 0.249398 -0.267303 -8.55381 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 12 2 0" />
                        </Face>
                        <Face id="12" plane="0.694746 0.186155 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 -0.671074 -0.179813 -0.719255 -9.19553 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 14 13 1 2" />
                        </Face>
                        <Face id="13" plane="0.508593 0.508583 -0.694749 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 7.17272 -0.491259 -0.491261 -0.719255 -9.19557 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 15 3 1 13" />
                        </Face>
                        <Face id="14" plane="0.186185 0.694745 -0.69474 -0.949037" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17269 -0.179811 -0.671074 -0.719255 -9.1956 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 16 4 3 15" />
                        </Face>
                        <Face id="15" plane="-0.186176 0.694738 -0.69475 -0.949045" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 0.179816 -0.671074 -0.719254 -9.19558 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 17 5 4 16" />
                        </Face>
                        <Face id="16" plane="-0.508582 0.508602 -0.694743 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 0.491261 -0.491261 -0.719253 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 18 6 5 17" />
                        </Face>
                        <Face id="17" plane="-0.694746 0.186167 -0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17252 0.671074 -0.179816 -0.719254 -9.19552 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 19 7 6 18" />
                        </Face>
                        <Face id="18" plane="-0.694751 -0.186145 -0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 0.671074 0.179812 -0.719255 -9.19549 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 20 8 7 19" />
                        </Face>
                        <Face id="19" plane="-0.508598 -0.50858 -0.694748 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 7.17249 0.491261 0.49126 -0.719254 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 21 9 8 20" />
                        </Face>
                        <Face id="20" plane="-0.18617 -0.694745 -0.694745 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258817 0 7.17263 0.179813 0.671074 -0.719255 -9.19543 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 22 10 9 21" />
                        </Face>
                        <Face id="21" plane="0.186155 -0.694744 -0.69475 -0.949044" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 -0.179814 0.671074 -0.719254 -9.19542 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 23 11 10 22" />
                        </Face>
                        <Face id="22" plane="0.50859 -0.508588 -0.694747 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.707109 0 7.17273 -0.491262 0.491258 -0.719255 -9.19545 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 12 11 23" />
                        </Face>
                        <Face id="23" plane="0.694738 -0.186155 -0.694755 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17274 -0.671074 0.179811 -0.719255 -9.1955 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 24 14 2 12" />
                        </Face>
                        <Face id="24" plane="0.935113 0.250562 -0.250563 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28236 -0.242025 -0.0648507 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 26 25 13 14" />
                        </Face>
                        <Face id="25" plane="0.684533 0.684564 -0.25057 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707106 0 8.2823 -0.177175 -0.177175 -0.9681 -8.78248 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 27 15 13 25" />
                        </Face>
                        <Face id="26" plane="0.250583 0.935109 -0.250557 -0.935106" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28229 -0.0648499 -0.242027 -0.9681 -8.78245 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 28 16 15 27" />
                        </Face>
                        <Face id="27" plane="-0.25056 0.935116 -0.250554 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 0.0648515 -0.242025 -0.9681 -8.78249 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 29 17 16 28" />
                        </Face>
                        <Face id="28" plane="-0.684553 0.68455 -0.250557 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 0.177174 -0.177174 -0.968101 -8.78251 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 30 18 17 29" />
                        </Face>
                        <Face id="29" plane="-0.935114 0.250557 -0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28208 0.242025 -0.0648515 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 31 19 18 30" />
                        </Face>
                        <Face id="30" plane="-0.935116 -0.250555 -0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 0.242025 0.0648499 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 32 20 19 31" />
                        </Face>
                        <Face id="31" plane="-0.684544 -0.684557 -0.25056 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 0.177174 0.177174 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 33 21 20 32" />
                        </Face>
                        <Face id="32" plane="-0.250568 -0.935113 -0.250557 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.25882 0 8.28216 0.0648506 0.242025 -0.9681 -8.78243 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 34 22 21 33" />
                        </Face>
                        <Face id="33" plane="0.250578 -0.93511 -0.250559 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 -0.064851 0.242025 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 35 23 22 34" />
                        </Face>
                        <Face id="34" plane="0.684545 -0.684556 -0.250563 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 -0.177175 0.177174 -0.9681 -8.78244 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 24 23 35" />
                        </Face>
                        <Face id="35" plane="0.935114 -0.250561 -0.25056 -0.935115" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 -0.242025 0.0648494 -0.9681 -8.78247 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 36 26 14 24" />
                        </Face>
                        <Face id="36" plane="0.935113 0.250563 0.250562 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.25882 0.965926 0 8.28235 0.242024 0.0648504 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 38 37 25 26" />
                        </Face>
                        <Face id="37" plane="0.684548 0.684554 0.25056 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 8.28229 0.177175 0.177175 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 39 27 25 37" />
                        </Face>
                        <Face id="38" plane="0.250565 0.935114 0.250559 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 8.28228 0.0648496 0.242026 -0.9681 -7.74484 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 40 28 27 39" />
                        </Face>
                        <Face id="39" plane="-0.250554 0.935115 0.250567 -0.935111" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258823 0 8.2822 -0.0648514 0.242025 -0.9681 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 41 29 28 40" />
                        </Face>
                        <Face id="40" plane="-0.684554 0.684546 0.250564 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707106 -0.707108 0 8.28202 -0.177174 0.177174 -0.968101 -7.74482 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 42 30 29 41" />
                        </Face>
                        <Face id="41" plane="-0.935113 0.250566 0.250561 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 8.28207 -0.242026 0.0648517 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 43 31 30 42" />
                        </Face>
                        <Face id="42" plane="-0.935113 -0.250561 0.250563 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 8.28211 -0.242026 -0.0648501 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 44 32 31 43" />
                        </Face>
                        <Face id="43" plane="-0.684555 -0.684544 0.250569 -0.935112" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707107 -0.707107 0 8.28216 -0.177174 -0.177174 -0.968101 -7.74483 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 45 33 32 44" />
                        </Face>
                        <Face id="44" plane="-0.250547 -0.935117 0.250562 -0.935113" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 8.28217 -0.0648506 -0.242026 -0.9681 -7.7449 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 46 34 33 45" />
                        </Face>
                        <Face id="45" plane="0.250571 -0.935114 0.250552 -0.935109" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258821 0 8.28228 0.0648508 -0.242025 -0.9681 -7.74488 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 47 35 34 46" />
                        </Face>
                        <Face id="46" plane="0.68455 -0.684552 0.250559 -0.93511" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 8.28231 0.177176 -0.177175 -0.9681 -7.74491 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 36 35 47" />
                        </Face>
                        <Face id="47" plane="0.935115 -0.25056 0.250561 -0.935114" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 8.28234 0.242026 -0.0648496 -0.9681 -7.74487 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 48 38 26 36" />
                        </Face>
                        <Face id="48" plane="0.694747 0.186155 0.694747 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258818 0.965926 0 7.17269 0.671072 0.179812 -0.719257 -7.08919 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 50 49 37 38" />
                        </Face>
                        <Face id="49" plane="0.508588 0.508596 0.694744 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707108 0.707106 0 7.17272 0.491258 0.49126 -0.719256 -7.08917 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 51 39 37 49" />
                        </Face>
                        <Face id="50" plane="0.186149 0.694749 0.694747 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 7.17268 0.17981 0.671072 -0.719257 -7.08913 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 52 40 39 51" />
                        </Face>
                        <Face id="51" plane="-0.186159 0.694743 0.69475 -0.949039" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 7.17256 -0.179815 0.671072 -0.719256 -7.08915 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 53 41 40 52" />
                        </Face>
                        <Face id="52" plane="-0.508583 0.508594 0.694749 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707107 0 7.1724 -0.491259 0.491259 -0.719257 -7.08918 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 54 42 41 53" />
                        </Face>
                        <Face id="53" plane="-0.694746 0.186158 0.694746 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258822 -0.965925 0 7.17253 -0.671072 0.179815 -0.719256 -7.0892 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 55 43 42 54" />
                        </Face>
                        <Face id="54" plane="-0.694746 -0.186159 0.694747 -0.949041" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258817 -0.965926 0 7.1725 -0.671072 -0.179812 -0.719257 -7.08923 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 56 44 43 55" />
                        </Face>
                        <Face id="55" plane="-0.508592 -0.508591 0.694744 -0.949042" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 -0.707108 0 7.17249 -0.49126 -0.491258 -0.719256 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 57 45 44 56" />
                        </Face>
                        <Face id="56" plane="-0.186154 -0.69475 0.694744 -0.949038" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258818 0 7.17262 -0.179812 -0.671072 -0.719257 -7.08929 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 58 46 45 57" />
                        </Face>
                        <Face id="57" plane="0.186129 -0.694755 0.694746 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 0.25882 0 7.17263 0.179814 -0.671072 -0.719256 -7.0893 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 59 47 46 58" />
                        </Face>
                        <Face id="58" plane="0.508605 -0.508572 0.694748 -0.949043" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707105 0.707109 0 7.17272 0.49126 -0.491257 -0.719257 -7.08927 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 48 47 59" />
                        </Face>
                        <Face id="59" plane="0.694745 -0.186155 0.694748 -0.94904" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 7.17273 0.671072 -0.179811 -0.719257 -7.08922 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 60 50 38 48" />
                        </Face>
                        <Face id="60" plane="0.258195 0.0691838 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258819 0.965926 0 4.1412 0.930779 0.249401 -0.267302 -7.48467 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 49 50" />
                        </Face>
                        <Face id="61" plane="0.189004 0.189019 0.963613 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 0.707107 0 4.14117 0.681376 0.681376 -0.267306 -7.4845 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 51 49" />
                        </Face>
                        <Face id="62" plane="0.0691902 0.258196 0.963612 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965927 0.258815 0 4.14115 0.249397 0.93078 -0.267302 -7.48458 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 52 51" />
                        </Face>
                        <Face id="63" plane="-0.069185 0.258198 0.963611 -0.963609" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.965925 -0.258822 0 4.14105 -0.249404 0.930778 -0.267302 -7.48459 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 53 52" />
                        </Face>
                        <Face id="64" plane="-0.18901 0.189019 0.963612 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.707107 -0.707106 0 4.14093 -0.681377 0.681377 -0.267302 -7.48464 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 54 53" />
                        </Face>
                        <Face id="65" plane="-0.258201 0.069179 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="-0.258823 -0.965925 0 4.14099 -0.930778 0.249404 -0.267302 -7.48468 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 55 54" />
                        </Face>
                        <Face id="66" plane="-0.258204 -0.0691815 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258819 -0.965926 0 4.141 -0.930777 -0.249401 -0.267306 -7.48461 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 56 55" />
                        </Face>
                        <Face id="67" plane="-0.189012 -0.189023 0.96361 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707106 -0.707108 0 4.14099 -0.681379 -0.681375 -0.267303 -7.48476 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 57 56" />
                        </Face>
                        <Face id="68" plane="-0.0691892 -0.258205 0.963609 -0.963611" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965926 -0.258819 0 4.14106 -0.249401 -0.930779 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 58 57" />
                        </Face>
                        <Face id="69" plane="0.0691877 -0.258201 0.963611 -0.963612" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.965925 0.258822 0 4.14115 0.249404 -0.930778 -0.267302 -7.48481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 59 58" />
                        </Face>
                        <Face id="70" plane="0.189011 -0.189022 0.963611 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.707104 0.70711 0 4.14118 0.681378 -0.681374 -0.267306 -7.48465 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 60 59" />
                        </Face>
                        <Face id="71" plane="0.258197 -0.0691834 0.963612 -0.96361" album="TGEDemo" material="FILLER_TILE1_04" texgens="0.258815 0.965927 0 4.1412 0.930779 -0.249397 -0.267302 -7.48472 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 61 50 60" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="3 57 10" rot="1 0 0 0" scale="" transform="1 0 0 3 0 3 0 57 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="194" nextVertexID="225">
                        <Vertices>
                            <Vertex pos="1 1.66667 1" />
                            <Vertex pos="1 2.33333 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1.66667 1" />
                            <Vertex pos="-1 2.33333 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="162" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="163" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="165" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="166" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="167" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="178" plane="0 0.948683 0.316228 -1.89737" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-3 57 10" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 3 0 57 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="175" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="1 0.333334 1" />
                            <Vertex pos="1 0.333334 -1" />
                            <Vertex pos="-1 0.333334 -1" />
                            <Vertex pos="-1 0.333334 1" />
                        </Vertices>
                        <Face id="168" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="169" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 4 5" />
                        </Face>
                        <Face id="170" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 6 7 1" />
                        </Face>
                        <Face id="171" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 7 4 2" />
                        </Face>
                        <Face id="172" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 3 5 6" />
                        </Face>
                        <Face id="173" plane="0 1 0 -0.333334" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-3 57 10" rot="1 0 0 0" scale="" transform="1 0 0 -3 0 3 0 57 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="175" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="5 1 -1" />
                            <Vertex pos="5 1 1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="5 0.333334 1" />
                            <Vertex pos="5 0.333334 -1" />
                            <Vertex pos="-1 0.333334 -1" />
                            <Vertex pos="-1 0.333334 1" />
                        </Vertices>
                        <Face id="168" plane="0 1 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="169" plane="1 0 0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="170" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="171" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 4" />
                        </Face>
                        <Face id="172" plane="-0 -0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="173" plane="-0 -1 -0 0.333334" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="3 67 8" rot="1 0 0 0" scale="" transform="1 0 0 3 0 3 0 67 0 0 1 8 0 0 0 1" group="-1" locked="0" nextFaceID="169" nextVertexID="225">
                        <Vertices>
                            <Vertex pos="1 6 1" />
                            <Vertex pos="1 6 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 6 1" />
                            <Vertex pos="-1 6 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="162" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="163" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="164" plane="0 1 -0 -6" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="165" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="166" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="167" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="1.03125 78 11.9375" rot="1 0 0 0" scale="" transform="1 0 0 1.03125 0 1 0 78 0 0 1 11.9375 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="-1.03125 -2 0.4375" />
                            <Vertex pos="-1.03125 -2 -0.4375" />
                            <Vertex pos="-1.03125 2 0.4375" />
                            <Vertex pos="-1.03125 2 -0.4375" />
                            <Vertex pos="1.03125 -2 0.4375" />
                            <Vertex pos="0.96875 -2 -0.4375" />
                            <Vertex pos="1.03125 2 0.4375" />
                            <Vertex pos="0.96875 2 -0.4375" />
                        </Vertices>
                        <Face id="30" plane="-1 -0 -0 -1.03125" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -14 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="31" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 33 0 0 -1 -14 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="32" plane="0 1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 63 0 0 -1 -14 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="33" plane="0 -0 1 -0.4375" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 33 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="34" plane="0.997459 0 -0.071247 -0.997459" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 -0.071247 0 -0.997459 -11.7558 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="35" plane="0 0 -1 -0.4375" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 63 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="4.96875 78 11.9375" rot="1 0 0 0" scale="" transform="1 0 0 4.96875 0 1 0 78 0 0 1 11.9375 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="1.03125 -2 0.4375" />
                            <Vertex pos="1.03125 -2 -0.4375" />
                            <Vertex pos="1.03125 2 0.4375" />
                            <Vertex pos="1.03125 2 -0.4375" />
                            <Vertex pos="-1.03125 -2 0.4375" />
                            <Vertex pos="-0.96875 -2 -0.4375" />
                            <Vertex pos="-1.03125 2 0.4375" />
                            <Vertex pos="-0.96875 2 -0.4375" />
                        </Vertices>
                        <Face id="30" plane="1 0 0 -1.03125" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -14 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="31" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 159 0 0 -1 -14 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="32" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 -63 0 0 -1 -14 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="33" plane="0 0 1 -0.4375" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 159 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="34" plane="-0.997459 -0 -0.0712468 -0.997459" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0.071247 0 -0.997459 -11.7558 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="35" plane="0 0 -1 -0.4375" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 -63 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="2.15625 78 13.4375" rot="1 0 0 0" scale="" transform="1 0 0 2.15625 0 1 0 78 0 0 1 13.4375 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="-0.09375 -2 1.0625" />
                            <Vertex pos="0.09375 -2 1.0625" />
                            <Vertex pos="-0.09375 -2 -1.0625" />
                            <Vertex pos="0.09375 -2 -0.437499" />
                            <Vertex pos="-0.09375 2 1.0625" />
                            <Vertex pos="0.09375 2 1.0625" />
                            <Vertex pos="-0.09375 2 -1.0625" />
                            <Vertex pos="0.09375 2 -0.437499" />
                        </Vertices>
                        <Face id="30" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 69 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="31" plane="0 1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 27 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="32" plane="0 -0 1 -1.0625" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 69 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="33" plane="-1 -0 -0 -0.09375" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="34" plane="1 0 0 -0.09375" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="35" plane="0.957826 0 -0.287347 -0.21551" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 -0.287348 0 -0.957826 -61.4995 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="3.84375 78 13.4375" rot="1 0 0 0" scale="" transform="1 0 0 3.84375 0 1 0 78 0 0 1 13.4375 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="0.09375 -2 1.0625" />
                            <Vertex pos="-0.09375 -2 1.0625" />
                            <Vertex pos="0.09375 -2 -1.0625" />
                            <Vertex pos="-0.09375 -2 -0.437498" />
                            <Vertex pos="0.09375 2 1.0625" />
                            <Vertex pos="-0.09375 2 1.0625" />
                            <Vertex pos="0.09375 2 -1.0625" />
                            <Vertex pos="-0.09375 2 -0.437498" />
                        </Vertices>
                        <Face id="30" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 123 0 0 -1 -62.0001 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="31" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 -27 0 0 -1 -62.0001 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="32" plane="0 0 1 -1.0625" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 123 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="33" plane="1 0 0 -0.09375" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -62.0001 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="34" plane="-1 -0 -0 -0.09375" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -62.0001 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="35" plane="-0.957826 0 -0.287347 -0.21551" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0.287348 0 -0.957826 -61.4995 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="2.40625 78 13.75" rot="1 0 0 0" scale="" transform="1 0 0 2.40625 0 1 0 78 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="-0.15625 -2 0.749999" />
                            <Vertex pos="0.15625 -2 0.749999" />
                            <Vertex pos="-0.15625 -2 -0.749999" />
                            <Vertex pos="0.15625 -2 -0.374999" />
                            <Vertex pos="-0.15625 2 0.749999" />
                            <Vertex pos="0.15625 2 0.749999" />
                            <Vertex pos="-0.15625 2 -0.749999" />
                            <Vertex pos="0.15625 2 -0.374999" />
                        </Vertices>
                        <Face id="30" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 77 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="31" plane="0 1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 19 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="32" plane="0 -0 1 -0.749999" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 77 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="33" plane="-1 -0 -0 -0.15625" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="34" plane="1 0 0 -0.15625" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="35" plane="0.768221 0 -0.640184 -0.360103" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 -0.640184 0 -0.768221 -70.5903 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="3.59375 78 13.75" rot="1 0 0 0" scale="" transform="1 0 0 3.59375 0 1 0 78 0 0 1 13.75 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="0.15625 -2 0.749998" />
                            <Vertex pos="-0.15625 -2 0.749998" />
                            <Vertex pos="0.15625 -2 -0.749999" />
                            <Vertex pos="-0.15625 -2 -0.375" />
                            <Vertex pos="0.15625 2 0.749998" />
                            <Vertex pos="-0.15625 2 0.749998" />
                            <Vertex pos="0.15625 2 -0.749999" />
                            <Vertex pos="-0.15625 2 -0.375" />
                        </Vertices>
                        <Face id="30" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 115 0 0 -1 -72.0001 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="31" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 -19 0 0 -1 -72.0001 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="32" plane="0 0 1 -0.749998" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 115 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="33" plane="1 0 0 -0.15625" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -72.0001 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="34" plane="-1 -0 -2.11928e-007 -0.15625" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -72.0001 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="35" plane="-0.768221 0 -0.640185 -0.360104" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0.640184 0 -0.768221 -70.5903 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="2.78125 78 13.9375" rot="1 0 0 0" scale="" transform="1 0 0 2.78125 0 1 0 78 0 0 1 13.9375 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="-0.21875 -2 0.5625" />
                            <Vertex pos="0.21875 -2 0.5625" />
                            <Vertex pos="-0.21875 -2 -0.562499" />
                            <Vertex pos="0.21875 -2 -0.437498" />
                            <Vertex pos="-0.21875 2 0.5625" />
                            <Vertex pos="0.21875 2 0.5625" />
                            <Vertex pos="-0.21875 2 -0.562499" />
                            <Vertex pos="0.21875 2 -0.437498" />
                        </Vertices>
                        <Face id="30" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 89 0 0 -1 -78 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="31" plane="0 1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 7 0 0 -1 -78 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="32" plane="0 -0 1 -0.5625" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 89 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="33" plane="-1 -0 -0 -0.21875" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -78 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="34" plane="1 0 0 -0.21875" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -78 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="35" plane="0.274723 0 -0.961523 -0.48076" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 -0.961524 0 -0.274721 -76.2481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="3.21875 78 13.9375" rot="1 0 0 0" scale="" transform="1 0 0 3.21875 0 1 0 78 0 0 1 13.9375 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="0.21875 -2 0.5625" />
                            <Vertex pos="-0.21875 -2 0.5625" />
                            <Vertex pos="0.21875 -2 -0.562499" />
                            <Vertex pos="-0.21875 -2 -0.437498" />
                            <Vertex pos="0.21875 2 0.5625" />
                            <Vertex pos="-0.21875 2 0.5625" />
                            <Vertex pos="0.21875 2 -0.562499" />
                            <Vertex pos="-0.21875 2 -0.437498" />
                        </Vertices>
                        <Face id="30" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 103 0 0 -1 -78 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="31" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 -7 0 0 -1 -78 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="32" plane="0 0 1 -0.5625" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 103 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="33" plane="1 0 0 -0.21875" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -78 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="34" plane="-1 -0 -0 -0.21875" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -78 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="35" plane="-0.274723 0 -0.961523 -0.48076" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0.961524 0 -0.274721 -76.2481 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="1.03125 78 13.4375" rot="1 0 0 0" scale="" transform="1 0 0 1.03125 0 1 0 78 0 0 1 13.4375 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="-1.03125 -2 1.0625" />
                            <Vertex pos="-1.03125 -2 -1.0625" />
                            <Vertex pos="-1.03125 2 1.0625" />
                            <Vertex pos="-1.03125 2 -1.0625" />
                            <Vertex pos="1.03125 -2 1.0625" />
                            <Vertex pos="1.03125 -2 -1.0625" />
                            <Vertex pos="1.03125 2 1.0625" />
                            <Vertex pos="1.03125 2 -1.0625" />
                        </Vertices>
                        <Face id="30" plane="-1 -0 -0 -1.03125" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="31" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 33 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="32" plane="0 1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 63 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="33" plane="1 0 0 -1.03125" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="34" plane="0 -0 1 -1.0625" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 33 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="35" plane="0 0 -1 -1.0625" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 63 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="4.96875 78 13.4375" rot="1 0 0 0" scale="" transform="1 0 0 4.96875 0 1 0 78 0 0 1 13.4375 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="1.03125 -2 1.0625" />
                            <Vertex pos="1.03125 -2 -1.0625" />
                            <Vertex pos="1.03125 2 1.0625" />
                            <Vertex pos="1.03125 2 -1.0625" />
                            <Vertex pos="-1.03125 -2 1.0625" />
                            <Vertex pos="-1.03125 -2 -1.0625" />
                            <Vertex pos="-1.03125 2 1.0625" />
                            <Vertex pos="-1.03125 2 -1.0625" />
                        </Vertices>
                        <Face id="30" plane="1 0 0 -1.03125" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="31" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 159 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="32" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 -63 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="33" plane="-1 -0 -0 -1.03125" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -62 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="34" plane="0 0 1 -1.0625" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 159 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="35" plane="0 0 -1 -1.0625" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 -63 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="1 78 9.25" rot="1 0 0 0" scale="" transform="1 0 0 1 0 1 0 78 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="-1 -2 2.25" />
                            <Vertex pos="-1 -2 -2.25" />
                            <Vertex pos="-1 2 2.25" />
                            <Vertex pos="-1 2 -2.25" />
                            <Vertex pos="1 -2 2.25" />
                            <Vertex pos="1 -2 -2.25" />
                            <Vertex pos="1 2 2.25" />
                            <Vertex pos="1 2 -2.25" />
                        </Vertices>
                        <Face id="30" plane="-1 -0 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="31" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="32" plane="0 1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 0 -1 72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="33" plane="1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="34" plane="0 -0 1 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="35" plane="0 0 -1 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="5 78 9.25" rot="1 0 0 0" scale="" transform="1 0 0 5 0 1 0 78 0 0 1 9.25 0 0 0 1" group="-1" locked="0" nextFaceID="37" nextVertexID="49">
                        <Vertices>
                            <Vertex pos="1 -2 2.25" />
                            <Vertex pos="1 -2 -2.25" />
                            <Vertex pos="1 2 2.25" />
                            <Vertex pos="1 2 -2.25" />
                            <Vertex pos="-1 -2 2.25" />
                            <Vertex pos="-1 -2 -2.25" />
                            <Vertex pos="-1 2 2.25" />
                            <Vertex pos="-1 2 -2.25" />
                        </Vertices>
                        <Face id="30" plane="1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="31" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 160 0 0 -1 72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="32" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 -64 0 0 -1 72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="33" plane="-1 -0 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 72 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                        <Face id="34" plane="0 0 1 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 160 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="35" plane="0 0 -1 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 -64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="-2.5 84 10" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 84 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="169" nextVertexID="225">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="162" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="163" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="164" plane="0 1 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="165" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="166" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="167" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="-2.5 79 11.5" rot="1 0 0 0" scale="" transform="1 0 0 -2.5 0 1 0 79 0 0 1 11.5 0 0 0 1" group="-1" locked="0" nextFaceID="169" nextVertexID="225">
                        <Vertices>
                            <Vertex pos="1 1 1" />
                            <Vertex pos="1 1 -1" />
                            <Vertex pos="1 -1 1" />
                            <Vertex pos="1 -1 -1" />
                            <Vertex pos="-1 1 1" />
                            <Vertex pos="-1 1 -1" />
                            <Vertex pos="-1 -1 1" />
                            <Vertex pos="-1 -1 -1" />
                        </Vertices>
                        <Face id="162" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="163" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="164" plane="0 1 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="165" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="166" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="167" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="3 89 10.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 89 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="1537" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -3.75" />
                            <Vertex pos="1 -1 -3.75" />
                            <Vertex pos="1 1 -3.75" />
                            <Vertex pos="-1 1 -3.75" />
                            <Vertex pos="1 -1 1.75" />
                            <Vertex pos="1 1 1.75" />
                            <Vertex pos="-1 1 1.75" />
                            <Vertex pos="-1 -1 1.75" />
                        </Vertices>
                        <Face id="1530" plane="0 0 -1 -3.75" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1531" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -120 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1532" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -120 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="1533" plane="0 1 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -120 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="1534" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -120 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="1535" plane="-0 0 1 -1.75" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 1 0 0 -120 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="3 89 10.75" rot="1 0 0 0" scale="" transform="1 0 0 3 0 1 0 89 0 0 1 10.75 0 0 0 1" group="-1" locked="0" nextFaceID="1537" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 3.75" />
                            <Vertex pos="-1 20 3.75" />
                            <Vertex pos="1 20 3.75" />
                            <Vertex pos="1 -1 3.75" />
                            <Vertex pos="1 -1 1.75" />
                            <Vertex pos="1 20 1.75" />
                            <Vertex pos="-1 20 1.75" />
                            <Vertex pos="-1 -1 1.75" />
                        </Vertices>
                        <Face id="1530" plane="-0 0 1 -3.75" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1531" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 0 0 -1 -120 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 3 2 5" />
                        </Face>
                        <Face id="1532" plane="-1 -0 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 32 0 0 -1 -120 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 1 0 7" />
                        </Face>
                        <Face id="1533" plane="0 1 0 -20" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -120 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 2 1 6" />
                        </Face>
                        <Face id="1534" plane="0 -1 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -120 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 0 3 4" />
                        </Face>
                        <Face id="1535" plane="0 0 -1 1.75" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 1 0 0 -120 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
