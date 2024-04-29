Eclipse Mixer is for HDR-like image processing, for both landscape and sun-shape in one photo.

It is impossible to express daylight landscape and sun-shape, because of too far exposure level.
![image](https://github.com/naokiueda/EclipseMixer/assets/6153725/8b56f44f-9b9f-41fe-ae55-0bcbfadd0987)


It needs a set of following two files, with exactly same position, same angle, and same pixel size.
1) Standard photo, normal exposure. The Sun is in frame.  The area near the Sun is usually over exposure.
2) The photo of the shape of the Sun, by using ND100000 filter.

How to process:
For each pixel, do following conversion.

  sunR, sunG, sunB, from Sun-Shape photo.
  baseR. baseG, base B, from Base photo.

Calc. Gray scale brightness.
  sunG =0.298912 * sunR + 0.586611 * sunG + 0.114478 * sunB

Mix Ratio
  How much to compress base file brightness.

Calc new value for base photo
  baseR' = (d + (1-d) * (G/256)) * baseR
  baseG' = (d + (1-d) * (G/256)) * baseG
  baseB' = (d + (1-d) * (G/256)) * baseB

![image](https://github.com/naokiueda/EclipseMixer/assets/6153725/fd108fa9-c487-4e0a-af5e-573c559a1443)

![image](https://github.com/naokiueda/EclipseMixer/assets/6153725/910238d4-6d4b-45c5-a445-cec157895f6f)







How to use app.

![image](https://github.com/naokiueda/EclipseMixer/assets/6153725/cfe4f593-a5c9-4ec9-825d-99fe8457f8cc)


- Instruction file.
	Write [Base file],[Sun-Shape file],[Output file] for each line.

- Mix Ratio 

- Skip or Overwrite for existing output file
