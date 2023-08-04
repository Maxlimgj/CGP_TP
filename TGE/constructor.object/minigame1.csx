<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2015/01/28 14:26:38">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="1" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <SceneGroups nextGroupID="3">
        <SceneGroup id="0" />
        <SceneGroup id="1" />
        <SceneGroup id="2" />
    </SceneGroups>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="1">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="8.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="30">
                    <Brush id="6" owner="0" type="0" pos="-1 -8.27084 103.477" rot="1 0 0 0" scale="" transform="25 0 0 -1 0 25 0 -8.27084 0 0 24.975 103.477 0 0 0 1" group="-1" locked="0" nextFaceID="715" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -5 0.5" />
                            <Vertex pos="3 -5 1.5" />
                            <Vertex pos="3 5 1.5" />
                            <Vertex pos="3 5 0.5" />
                            <Vertex pos="2.7 5 1.5" />
                            <Vertex pos="2.7 -5 1.5" />
                            <Vertex pos="2.7 5 0.5" />
                            <Vertex pos="2.7 -5 0.5" />
                        </Vertices>
                        <Face id="708" plane="1 -0 0 -3" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 160 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="709" plane="0 0 1 -1.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="710" plane="0 1 0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 4 6" />
                        </Face>
                        <Face id="711" plane="-0 -1 -0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 7" />
                        </Face>
                        <Face id="712" plane="-0 -5.96046e-009 -1 0.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 1 0 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="713" plane="-1 0 0 2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-1 -8.27084 103.477" rot="1 0 0 0" scale="" transform="25 0 0 -1 0 25 0 -8.27084 0 0 24.975 103.477 0 0 0 1" group="-1" locked="0" nextFaceID="721" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 5 0.5" />
                            <Vertex pos="-3 5 1.5" />
                            <Vertex pos="-3 -5 1.5" />
                            <Vertex pos="-3 -5 0.5" />
                            <Vertex pos="-2.7 5 1.5" />
                            <Vertex pos="-2.7 -5 1.5" />
                            <Vertex pos="-2.7 5 0.5" />
                            <Vertex pos="-2.7 -5 0.5" />
                        </Vertices>
                        <Face id="714" plane="-1 -0 -0 -3" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="715" plane="-0 0 1 -1.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="716" plane="-0 1 0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="717" plane="0 -1 0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="718" plane="0 5.96046e-009 -1 0.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 1 0 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="719" plane="1 -0 0 2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-1 -8.27084 103.477" rot="1 0 0 0" scale="" transform="25 0 0 -1 0 25 0 -8.27084 0 0 24.975 103.477 0 0 0 1" group="-1" locked="0" nextFaceID="727" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.7 5 1.5" />
                            <Vertex pos="-2.7 5 1.5" />
                            <Vertex pos="-2.7 5 0.5" />
                            <Vertex pos="2.7 5 0.5" />
                            <Vertex pos="2.7 4.5 1.5" />
                            <Vertex pos="2.7 4.5 0.5" />
                            <Vertex pos="-2.7 4.5 1.5" />
                            <Vertex pos="-2.7 4.5 0.5" />
                        </Vertices>
                        <Face id="720" plane="-0 1 0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="721" plane="1 0 0 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="722" plane="0 0 1 -1.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="723" plane="-1.10379e-008 -0 -1 0.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 1 0 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 2 7" />
                        </Face>
                        <Face id="724" plane="-1 0 0 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="725" plane="0 -1 0 4.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 96 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-1 -8.27084 103.477" rot="1 0 0 0" scale="" transform="25 0 0 -1 0 25 0 -8.27084 0 0 24.975 103.477 0 0 0 1" group="-1" locked="0" nextFaceID="733" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.7 -5 1.5" />
                            <Vertex pos="2.7 -5 1.5" />
                            <Vertex pos="2.7 -5 0.5" />
                            <Vertex pos="-2.7 -5 0.5" />
                            <Vertex pos="2.7 -4.5 1.5" />
                            <Vertex pos="2.7 -4.5 0.5" />
                            <Vertex pos="-2.7 -4.5 1.5" />
                            <Vertex pos="-2.7 -4.5 0.5" />
                        </Vertices>
                        <Face id="726" plane="-0 -1 -0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="727" plane="1 -4.76837e-007 0 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="728" plane="0 -0 1 -1.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="729" plane="1.10379e-008 0 -1 0.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 1 0 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="730" plane="-1 -0 -2.38419e-007 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 7 6 0" />
                        </Face>
                        <Face id="731" plane="0 1 -0 4.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 96 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-1 -7.77083 210.977" rot="1 0 0 0" scale="" transform="25 0 0 -1 0 25 0 -7.77083 0 0 24.975 210.977 0 0 0 1" group="-1" locked="0" nextFaceID="739" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.7 4.5 1.5" />
                            <Vertex pos="2.7 -4.5 1.5" />
                            <Vertex pos="-2.7 -4.5 1.5" />
                            <Vertex pos="-2.7 4.5 1.5" />
                            <Vertex pos="2.7 4.5 1.375" />
                            <Vertex pos="-2.7 4.5 1.375" />
                            <Vertex pos="2.7 -4.5 1.375" />
                            <Vertex pos="-2.7 -4.5 1.375" />
                        </Vertices>
                        <Face id="732" plane="0 0 1 -1.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="733" plane="0 1 0 -4.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 96 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="734" plane="1 2.6491e-008 0 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 0 4 6" />
                        </Face>
                        <Face id="735" plane="-1 2.6491e-008 0 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 2 7" />
                        </Face>
                        <Face id="736" plane="0 -1 0 -4.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 96 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 2 1 6" />
                        </Face>
                        <Face id="737" plane="0 1.32455e-008 -1 1.375" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 96 0 -1.11111 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="-1 -8.27084 103.477" rot="1 0 0 0" scale="" transform="25 0 0 -1 0 25 0 -8.27084 0 0 24.975 103.477 0 0 0 1" group="-1" locked="0" nextFaceID="715" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 -5 -1.5" />
                            <Vertex pos="3 -5 0.5" />
                            <Vertex pos="3 5 0.5" />
                            <Vertex pos="3 5 -1.5" />
                            <Vertex pos="2.7 -5 -1.5" />
                            <Vertex pos="2.7 5 -1.5" />
                            <Vertex pos="2.7 5 0.5" />
                            <Vertex pos="2.7 -5 0.5" />
                        </Vertices>
                        <Face id="708" plane="1 0 0 -3" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 160 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="709" plane="0 0 -1 -1.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 0 3 5" />
                        </Face>
                        <Face id="710" plane="0 1 -0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 3 2 6" />
                        </Face>
                        <Face id="711" plane="-0 -1 -0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 1 0 4" />
                        </Face>
                        <Face id="712" plane="0 5.96046e-009 1 -0.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 1 0 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 2 1 7" />
                        </Face>
                        <Face id="713" plane="-1 0 0 2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-1 -8.27084 103.477" rot="1 0 0 0" scale="" transform="25 0 0 -1 0 25 0 -8.27084 0 0 24.975 103.477 0 0 0 1" group="-1" locked="0" nextFaceID="721" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 -5 -1.5" />
                            <Vertex pos="-3 5 -1.5" />
                            <Vertex pos="-3 5 0.5" />
                            <Vertex pos="-3 -5 0.5" />
                            <Vertex pos="-2.7 -5 -1.5" />
                            <Vertex pos="-2.7 5 -1.5" />
                            <Vertex pos="-2.7 5 0.5" />
                            <Vertex pos="-2.7 -5 0.5" />
                        </Vertices>
                        <Face id="714" plane="-1 0 0 -3" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="715" plane="0 0 -1 -1.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 4 5 1" />
                        </Face>
                        <Face id="716" plane="0 1 -0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 5 6 2" />
                        </Face>
                        <Face id="717" plane="0 -1 0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 3 7 4" />
                        </Face>
                        <Face id="718" plane="0 -5.96046e-009 1 -0.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 1 0 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 6 7" />
                        </Face>
                        <Face id="719" plane="1 0 0 2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-1 -8.27084 103.477" rot="1 0 0 0" scale="" transform="25 0 0 -1 0 25 0 -8.27084 0 0 24.975 103.477 0 0 0 1" group="-1" locked="0" nextFaceID="727" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.7 5 -1.5" />
                            <Vertex pos="2.7 5 -1.5" />
                            <Vertex pos="2.7 5 0.5" />
                            <Vertex pos="-2.7 5 0.5" />
                            <Vertex pos="2.7 4.5 0.5" />
                            <Vertex pos="2.7 4.5 -1.5" />
                            <Vertex pos="-2.7 4.5 -1.5" />
                            <Vertex pos="-2.7 4.5 0.5" />
                        </Vertices>
                        <Face id="720" plane="0 1 -0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="721" plane="1 0 0 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="722" plane="-0 -0 -1 -1.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="723" plane="1.10379e-008 0 1 -0.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 1 0 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="724" plane="-1 0 0 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="725" plane="-0 -1 -0 4.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 96 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-1 -8.27084 103.477" rot="1 0 0 0" scale="" transform="25 0 0 -1 0 25 0 -8.27084 0 0 24.975 103.477 0 0 0 1" group="-1" locked="0" nextFaceID="733" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.7 -5 0.5" />
                            <Vertex pos="2.7 -5 0.5" />
                            <Vertex pos="2.7 -5 -1.5" />
                            <Vertex pos="-2.7 -5 -1.5" />
                            <Vertex pos="2.7 -4.5 0.5" />
                            <Vertex pos="2.7 -4.5 -1.5" />
                            <Vertex pos="-2.7 -4.5 -1.5" />
                            <Vertex pos="-2.7 -4.5 0.5" />
                        </Vertices>
                        <Face id="726" plane="0 -1 -0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="727" plane="1 -4.76837e-007 -1.19209e-007 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="728" plane="0 0 -1 -1.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="729" plane="-1.10379e-008 5.26328e-015 1 -0.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 1 0 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="730" plane="-1 0 0 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 3 6 7" />
                        </Face>
                        <Face id="731" plane="0 1 -0 4.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 96 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-1 -8.27084 103.477" rot="1 0 0 0" scale="" transform="25 0 0 -1 0 25 0 -8.27084 0 0 24.975 103.477 0 0 0 1" group="-1" locked="0" nextFaceID="745" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="2.7 -4.5 -1.5" />
                            <Vertex pos="2.7 4.5 -1.5" />
                            <Vertex pos="-2.7 4.5 -1.5" />
                            <Vertex pos="-2.7 -4.5 -1.5" />
                            <Vertex pos="-2.7 4.5 -1.325" />
                            <Vertex pos="2.7 4.5 -1.325" />
                            <Vertex pos="2.7 -4.5 -1.325" />
                            <Vertex pos="-2.7 -4.5 -1.325" />
                        </Vertices>
                        <Face id="738" plane="-0 -0 -1 -1.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="739" plane="0 1 0 -4.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 96 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 2 1 5" />
                        </Face>
                        <Face id="740" plane="1 0 -0 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 5 1 0 6" />
                        </Face>
                        <Face id="741" plane="-1 0 0 -2.7" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1.11111 0 160 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 4 7" />
                        </Face>
                        <Face id="742" plane="0 -1 0 -4.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1.11111 0 0 96 0 0 -1.11111 -47.1111 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="743" plane="-0 0 1 1.325" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1.11111 0 0 96 0 -1.11111 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 4 5 6" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-1 -8.27084 104.102" rot="1 0 0 0" scale="" transform="22.5 0 0 -1 0 22.5 0 -8.27084 0 0 22.4775 104.102 0 0 0 1" group="-1" locked="0" nextFaceID="721" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3 2.77778 -1.5" />
                            <Vertex pos="3 5 -1.5" />
                            <Vertex pos="-3 5 -1.5" />
                            <Vertex pos="-3 2.77778 -1.5" />
                            <Vertex pos="3 5 -0.583333" />
                            <Vertex pos="-3 5 -0.583333" />
                            <Vertex pos="3 2.77778 -0.583333" />
                            <Vertex pos="-3 2.77778 -0.583333" />
                        </Vertices>
                        <Face id="714" plane="-0 -0 -1 -1.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 -1 0 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="715" plane="0 1 -0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 2 1 4 5" />
                        </Face>
                        <Face id="716" plane="1 0 -0 -3" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 160 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 1 0 6" />
                        </Face>
                        <Face id="717" plane="-1 0 0 -3" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 5 7" />
                        </Face>
                        <Face id="718" plane="0 -1 0 2.77778" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 96 0 0 1 -160 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 6 0 3 7" />
                        </Face>
                        <Face id="719" plane="-0 0 1 0.583333" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 96 1 0 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="-1 -7.27083 83.3517" rot="1 0 0 0" scale="" transform="22.5 0 0 -1 0 22.5 0 -7.27083 0 0 22.4775 83.3517 0 0 0 1" group="-1" locked="0" nextFaceID="727" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 -5 -0.583333" />
                            <Vertex pos="-3 -5 0.5" />
                            <Vertex pos="3 -5 0.5" />
                            <Vertex pos="3 -5 -0.583333" />
                            <Vertex pos="-3 -3.33333 0.5" />
                            <Vertex pos="3 -3.33333 0.5" />
                            <Vertex pos="3 -3.33333 -0.583333" />
                            <Vertex pos="-3 -3.33333 -0.583333" />
                        </Vertices>
                        <Face id="720" plane="0 -1 0 -5" album="TGEDemo" material="FILLER_TILE1_04" texgens="1 0 0 96 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 0 1 2 3" />
                        </Face>
                        <Face id="721" plane="-9.93411e-009 0 1 -0.5" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 1 0 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 1 4 5 2" />
                        </Face>
                        <Face id="722" plane="1 -0 0 -3" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 1 0 160 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 3 2 5 6" />
                        </Face>
                        <Face id="723" plane="-1 0 0 -3" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 160 0 0 -1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 4 1 0 7" />
                        </Face>
                        <Face id="724" plane="0 0 -1 -0.583333" album="TGEDemo" material="FILLER_TILE1_04" texgens="0 -1 0 96 1 0 0 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 0 3 6" />
                        </Face>
                        <Face id="725" plane="0 1 -0 3.33333" album="TGEDemo" material="FILLER_TILE1_04" texgens="-1 0 0 160 0 0 1 -48 0 1 1" texRot="0" texScale="1 1" texDiv="128 128">
                            <Indices indices=" 7 6 5 4" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
