<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2015/02/02 15:44:40">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="1" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="8" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="28">
                    <Brush id="3" owner="0" type="0" pos="-1.25 0 20" rot="1 0 0 0" scale="" transform="20 0 0 -1.25 0 40 0 0 0 0 20 20 0 0 0 1" group="-1" locked="0" nextFaceID="1219" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -2.5 -1" />
                            <Vertex pos="-1 2.5 -1" />
                            <Vertex pos="-1 2.5 1" />
                            <Vertex pos="-1 -2.5 1" />
                            <Vertex pos="-0.9 2.5 -1" />
                            <Vertex pos="-0.9 2.5 1" />
                            <Vertex pos="-0.9 -2.5 1" />
                            <Vertex pos="-0.9 -2.5 -1" />
                        </Vertices>
                        <Face id="1212" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1213" plane="0 1 -0 -2.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="1214" plane="0 -1 0 -2.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="1215" plane="-0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="1216" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 7 4 1" />
                        </Face>
                        <Face id="1217" plane="1 -0 0 0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 80 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="-1.25 0 20" rot="1 0 0 0" scale="" transform="20 0 0 -1.25 0 40 0 0 0 0 20 20 0 0 0 1" group="-1" locked="0" nextFaceID="1225" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.9 2.5 -1" />
                            <Vertex pos="1 2.5 -1" />
                            <Vertex pos="1 2.5 1" />
                            <Vertex pos="-0.9 2.5 1" />
                            <Vertex pos="1 2.25 1" />
                            <Vertex pos="1 2.25 -1" />
                            <Vertex pos="-0.9 2.25 1" />
                            <Vertex pos="-0.9 2.25 -1" />
                        </Vertices>
                        <Face id="1218" plane="0 1 -0 -2.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1219" plane="1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="1220" plane="0 0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="1221" plane="-0 -0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="1222" plane="-1 0 0 -0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 80 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="1223" plane="0 -1 0 2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="-1.25 0 20" rot="1 0 0 0" scale="" transform="20 0 0 -1.25 0 40 0 0 0 0 20 20 0 0 0 1" group="-1" locked="0" nextFaceID="1231" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.9 -2.5 1" />
                            <Vertex pos="1 -2.5 1" />
                            <Vertex pos="1 -2.5 -1" />
                            <Vertex pos="-0.9 -2.5 -1" />
                            <Vertex pos="1 -2.25 1" />
                            <Vertex pos="1 -2.25 -1" />
                            <Vertex pos="-0.9 -2.25 1" />
                            <Vertex pos="-0.9 -2.25 -1" />
                        </Vertices>
                        <Face id="1224" plane="-0 -1 -0 -2.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1225" plane="1 -0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="1226" plane="0 -0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="1227" plane="0 0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="1228" plane="-1 0 0 -0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 80 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="1229" plane="0 1 -0 2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="-0.35 0 -6" rot="1 0 0 0" scale="" transform="2 0 0 -0.35 0 25.2 0 0 0 0 20 -6 0 0 0 1" group="-1" locked="0" nextFaceID="1237" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.25 1" />
                            <Vertex pos="1 -2.25 1" />
                            <Vertex pos="-0.9 -2.25 1" />
                            <Vertex pos="-0.9 2.25 1" />
                            <Vertex pos="1 2.25 0.9" />
                            <Vertex pos="-0.9 2.25 0.9" />
                            <Vertex pos="1 -2.25 0.9" />
                            <Vertex pos="-0.9 -2.25 0.9" />
                        </Vertices>
                        <Face id="1230" plane="0 -0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1231" plane="0 1 0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="1232" plane="1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="1233" plane="-1 -0 -0 -0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 80 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 2 7" />
                        </Face>
                        <Face id="1234" plane="0 -1 0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="1235" plane="0 0 -1 0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 -1.11111 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-1.25 0 20" rot="1 0 0 0" scale="" transform="20 0 0 -1.25 0 40 0 0 0 0 20 20 0 0 0 1" group="-1" locked="0" nextFaceID="1243" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 -2.25 -1" />
                            <Vertex pos="1 2.25 -1" />
                            <Vertex pos="-0.9 2.25 -1" />
                            <Vertex pos="-0.9 -2.25 -1" />
                            <Vertex pos="1 2.25 -0.9" />
                            <Vertex pos="-0.9 2.25 -0.9" />
                            <Vertex pos="1 -2.25 -0.9" />
                            <Vertex pos="-0.9 -2.25 -0.9" />
                        </Vertices>
                        <Face id="1236" plane="-0 -0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1237" plane="0 1 -0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="1238" plane="1 0 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="1239" plane="-1 0 0 -0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 80 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="1240" plane="0 -1 0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="1241" plane="-0 0 1 0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 32 0 -1.11111 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-1.25 0 20" rot="1 0 0 0" scale="" transform="20 0 0 -1.25 0 40 0 0 0 0 20 20 0 0 0 1" group="-1" locked="0" nextFaceID="1249" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.25 0.9" />
                            <Vertex pos="1 2.25 -0.9" />
                            <Vertex pos="1 -2.25 -0.9" />
                            <Vertex pos="1 -2.25 0.9" />
                            <Vertex pos="0.9 2.25 0.9" />
                            <Vertex pos="0.9 -2.25 0.9" />
                            <Vertex pos="0.9 2.25 -0.9" />
                            <Vertex pos="0.9 -2.25 -0.9" />
                        </Vertices>
                        <Face id="1242" plane="1 0 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1243" plane="0 0 1 -0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 -1.11111 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="1244" plane="0 1 0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="1245" plane="-0 -1 -0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 2 7" />
                        </Face>
                        <Face id="1246" plane="0 0 -1 -0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 32 0 -1.11111 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="1247" plane="-1 0 0 0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1.11111 0 80 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-1.25 0 20" rot="1 0 0 0" scale="" transform="18 0 0 -1.25 0 36 0 0 0 0 18 20 0 0 0 1" group="-1" locked="0" nextFaceID="1225" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1.66667 -1" />
                            <Vertex pos="1 2.5 -1" />
                            <Vertex pos="-1 2.5 -1" />
                            <Vertex pos="-1 1.66667 -1" />
                            <Vertex pos="1 2.5 -0.333333" />
                            <Vertex pos="-1 2.5 -0.333333" />
                            <Vertex pos="1 1.66667 -0.333333" />
                            <Vertex pos="-1 1.66667 -0.333333" />
                        </Vertices>
                        <Face id="1218" plane="-0 -0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1219" plane="0 1 -0 -2.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="1220" plane="1 0 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="1221" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="1222" plane="0 -1 0 1.66667" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 80 0 0 1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="1223" plane="-0 0 1 0.333333" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 1 0 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-1.25 -150 20" rot="1 0 0 0" scale="" transform="18 0 0 -1.25 0 36 0 -150 0 0 18 20 0 0 0 1" group="-1" locked="0" nextFaceID="1225" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 1.66667 -1" />
                            <Vertex pos="1 2.5 -1" />
                            <Vertex pos="-1 2.5 -1" />
                            <Vertex pos="-1 1.66667 -1" />
                            <Vertex pos="1 2.5 -0.333333" />
                            <Vertex pos="-1 2.5 -0.333333" />
                            <Vertex pos="1 1.66667 -0.333333" />
                            <Vertex pos="-1 1.66667 -0.333333" />
                        </Vertices>
                        <Face id="1218" plane="-0 -0 -1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1219" plane="0 1 -0 -2.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 32 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="1220" plane="1 0 -0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="1221" plane="-1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="1222" plane="0 -1 0 1.66667" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 80 0 0 1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="1223" plane="-0 0 1 0.333333" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 32 1 0 0 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-1.25 0 20" rot="1 0 0 0" scale="" transform="20 0 0 -1.25 0 40 0 0 0 0 20 20 0 0 0 1" group="-1" locked="0" nextFaceID="1237" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.25 1" />
                            <Vertex pos="1 -2.25 1" />
                            <Vertex pos="-0.9 -2.25 1" />
                            <Vertex pos="-0.9 2.25 1" />
                            <Vertex pos="1 2.25 0.9" />
                            <Vertex pos="-0.9 2.25 0.9" />
                            <Vertex pos="1 -2.25 0.9" />
                            <Vertex pos="-0.9 -2.25 0.9" />
                        </Vertices>
                        <Face id="1230" plane="0 -0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1231" plane="0 1 0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="1232" plane="1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="1233" plane="-1 -0 -0 -0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 80 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 2 7" />
                        </Face>
                        <Face id="1234" plane="0 -1 0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="1235" plane="0 0 -1 0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 -1.11111 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-17.35 0 -6" rot="1 0 0 0" scale="" transform="2 0 0 -17.35 0 20.412 0 0 0 0 20 -6 0 0 0 1" group="-1" locked="0" nextFaceID="1237" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.25 1" />
                            <Vertex pos="1 -2.25 1" />
                            <Vertex pos="-0.9 -2.25 1" />
                            <Vertex pos="-0.9 2.25 1" />
                            <Vertex pos="1 2.25 0.9" />
                            <Vertex pos="-0.9 2.25 0.9" />
                            <Vertex pos="1 -2.25 0.9" />
                            <Vertex pos="-0.9 -2.25 0.9" />
                        </Vertices>
                        <Face id="1230" plane="0 -0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1231" plane="0 1 0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="1232" plane="1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="1233" plane="-1 -0 -0 -0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 80 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 2 7" />
                        </Face>
                        <Face id="1234" plane="0 -1 0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="1235" plane="0 0 -1 0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 -1.11111 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="15.15 0 -6" rot="1 0 0 0" scale="" transform="2 0 0 15.15 0 20.16 0 0 0 0 20 -6 0 0 0 1" group="-1" locked="0" nextFaceID="1237" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1 2.25 1" />
                            <Vertex pos="1 -2.25 1" />
                            <Vertex pos="-0.9 -2.25 1" />
                            <Vertex pos="-0.9 2.25 1" />
                            <Vertex pos="1 2.25 0.9" />
                            <Vertex pos="-0.9 2.25 0.9" />
                            <Vertex pos="1 -2.25 0.9" />
                            <Vertex pos="-0.9 -2.25 0.9" />
                        </Vertices>
                        <Face id="1230" plane="0 -0 1 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 32 0 -1 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="1231" plane="0 1 0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="1232" plane="1 0 0 -1" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 80 0 0 -1 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="1233" plane="-1 -0 -0 -0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 80 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 2 7" />
                        </Face>
                        <Face id="1234" plane="0 -1 0 -2.25" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 0 -1.11111 -32 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="1235" plane="0 0 -1 0.9" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 32 0 -1.11111 0 -80 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="4.5 2 16" rot="1 0 0 0" scale="" transform="1 0 0 4.5 0 1 0 2 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="139" nextVertexID="185">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="132" plane="1 -0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="133" plane="-1 0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="134" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="135" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="136" plane="-0 0 1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="137" plane="0 0 -1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="4.5 12.5 16" rot="1 0 0 0" scale="" transform="1 0 0 4.5 0 1 0 12.5 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="139" nextVertexID="185">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="132" plane="1 -0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="133" plane="-1 0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="134" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="135" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="136" plane="-0 0 1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="137" plane="0 0 -1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-7 23 16" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 23 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="139" nextVertexID="185">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="132" plane="1 -0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="133" plane="-1 0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="134" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="135" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="136" plane="-0 0 1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="137" plane="0 0 -1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-7 -8 16" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -8 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="139" nextVertexID="185">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="132" plane="1 -0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="133" plane="-1 0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="134" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="135" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="136" plane="-0 0 1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="137" plane="0 0 -1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-7 -18 16" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 -18 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="139" nextVertexID="185">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="132" plane="1 -0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="133" plane="-1 0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="134" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="135" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="136" plane="-0 0 1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="137" plane="0 0 -1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="4 -26.5 16" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -26.5 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="139" nextVertexID="185">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="132" plane="1 -0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="133" plane="-1 0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="134" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="135" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="136" plane="-0 0 1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="137" plane="0 0 -1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="4 -38.5 16" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -38.5 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="139" nextVertexID="185">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="132" plane="1 -0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="133" plane="-1 0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="134" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="135" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="136" plane="-0 0 1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="137" plane="0 0 -1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="-7 32.5 16" rot="1 0 0 0" scale="" transform="1 0 0 -7 0 1 0 32.5 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="139" nextVertexID="185">
                        <Vertices>
                            <Vertex pos="2 2 2" />
                            <Vertex pos="2 2 -2" />
                            <Vertex pos="2 -2 2" />
                            <Vertex pos="2 -2 -2" />
                            <Vertex pos="-2 2 2" />
                            <Vertex pos="-2 2 -2" />
                            <Vertex pos="-2 -2 2" />
                            <Vertex pos="-2 -2 -2" />
                        </Vertices>
                        <Face id="132" plane="1 -0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="133" plane="-1 0 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                        <Face id="134" plane="0 1 -0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="135" plane="0 -1 0 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 0 -1 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="136" plane="-0 0 1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="137" plane="0 0 -1 -2" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 64 0 -1 0 -64 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
