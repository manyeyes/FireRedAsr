# FireRedAsr
FireRedAsr is a C# library for decoding the FireRedASR AED-L model, designed for Automatic Speech Recognition (ASR).

### Introduction:
FireRedAsr is an Automatic Speech Recognition (ASR) library developed based on C#. This library boasts excellent compatibility, supporting framework versions such as net461+ and .NET6.0+. It not only focuses on efficiently completing speech recognition tasks but also features outstanding cross-platform capabilities. It supports compilation and invocation on multiple platforms including Windows, Linux, Android, macOS, and iOS, making it adaptable to a wide range of scenarios.

Its core dependency, the FireRedASR-AED model, is designed to balance high performance and computational efficiency. Adopting an Attention-based Encoder-Decoder (AED) architecture, it can serve as an efficient speech representation module in speech models based on Large Language Models (LLMs), providing stable and high-quality technical support for speech recognition tasks.

### Supported Models (ONNX)
| Model Name  | Type | Timestamp | Supported Languages | Download Link |
| ------------ | ------------ | ------------ | ------------ | ------------ |
|  fireredasr-aed-large-zh-en-onnx-offline-20250124 | Non-streaming | No | Chinese, English |[modelscope](https://www.modelscope.cn/models/manyeyes/fireredasr-aed-large-zh-en-onnx-offline-20250124 "modelscope") |
|  fireredasr2-aed-large-zh-en-onnx-offline-20260212 | Non-streaming | Yes | Chinese, English |[modelscope](https://www.modelscope.cn/models/manyeyes/fireredasr2-aed-large-zh-en-onnx-offline-20260212 "modelscope") |
|  fireredasr2-aed-large-zh-en-int8-onnx-offline-20260212 | Non-streaming | Yes | Chinese, English |[modelscope](https://www.modelscope.cn/models/manyeyes/fireredasr2-aed-large-zh-en-int8-onnx-offline-20260212 "modelscope") |

### How to Use
#### 1. Clone the Project Source Code
```bash
cd /path/to
git clone https://github.com/manyeyes/FireRedASR.git
```
#### 2. Download the model listed above to the directory: /path/to/FireRedASR/FireRedASR.Examples
```bash
cd /path/to/FireRedASR/FireRedASR.Examples
git clone https://www.modelscope.cn/manyeyes/[model-name].git
```
#### 3. Load the project using vs2022 (or other IDEs)
#### 4. Set the files in the model directory to: Copy to Output Directory -> Copy if newer
#### 5. Modify the code in the example: string modelName = [model-directory-name]
#### 6. How to Call
Refer to the sample code in FireRedAsrExamples.cs
#### 7. How to Run the Example Program
##### 1. Download the model to the Application directory (refer to the window prompt):
```bash
git clone https://www.modelscope.cn/manyeyes/fireredasr2-aed-large-zh-en-int8-onnx-offline-20260212.git
```
##### 2. Run the Example
```bash
-type offline -files /path/to/0.wav
```
##### 3. Running Results
```
/path/to/0.wav
{"text": "对我做了介绍啊那么我想说的是呢大家如果对我的研究感兴趣呢嗯","word":["对","我","做","了","介","绍","啊","那","么","我","想","说","的","是","呢","大","家","如","果","对","我","的","研","究","感","兴","趣","呢","嗯"],"timestamps":[[440,480],[600,640],[720,760],[840,960],[1040,1120],[1320,1360],[1760,1840],[1880,1960],[2080,2160],[2200,2280],[2360,2400],[2480,2560],[2600,2680],[2760,2840],[3200,3280],[3320,3400],[3480,3560],[3600,3640],[3680,3760],[3800,3880],[3880,3920],[3960,4040],[4080,4160],[4240,4320],[4400,4520],[4600,4680],[4760,4840],[5080,5120],[5560,5600]]}

/path/to/1.wav
{"text": "重点呢想谈三个问题首先呢就是这一轮全球金融动荡的表现","word":["重","点","呢","想","谈","三","个","问","题","首","先","呢","就","是","这","一","轮","全","球","金","融","动","荡","的","表","现"],"timestamps":[[280,360],[400,480],[560,600],[720,800],[920,1000],[1040,1120],[1160,1280],[1320,1440],[2080,2200],[2280,2360],[2440,2480],[2560,2640],[2720,2800],[2960,3040],[3120,3200],[3240,3320],[3440,3520],[3600,3680],[3760,3800],[3880,3920],[4000,4080],[4160,4240],[4280,4360],[4440,4560],[4640,4720],[5120,5160]]}

/path/to/2.wav
{"text": "well i don't wish to see it any more observed phoebe turning away her eyes it is certainly very like the old portrait","word":["well","i","don't","wish","to","see","it","any","more","observed","phoebe","turning","away","her","eyes","it","is","certainly","very","like","the","old","portrait"],"timestamps":[[760,800],[840,920],[920,1120],[1120,1360],[1400,1480],[1560,1640],[1720,1800],[1920,2000],[2200,2240],[2240,2680],[2680,3440],[3480,3840],[3920,4000],[4080,4280],[5000,5080],[5160,5240],[5360,5600],[5640,5920],[6040,6160],[6280,6320],[6400,6480],[6600,6680],[6680,7000]]}

recognition_elapsed_milliseconds:3645.171875
total_duration_milliseconds:18199.5625
rtf:0.2002889835950727
```
###### Related Projects:
* Voice Activity Detection (VAD) for reasonable segmentation of long audio files, project address: [AliFsmnVad](https://github.com/manyeyes/AliFsmnVad "AliFsmnVad") 
* Text Punctuation Prediction to address the lack of punctuation in recognition results, project address: [AliCTTransformerPunc](https://github.com/manyeyes/AliCTTransformerPunc "AliCTTransformerPunc")

###### Additional Notes:

Test Cases: FireRedASR.Examples.
Test CPU: Intel(R) Core(TM) i7-10750H CPU @ 2.60GHz   2.59 GHz
Supported Platforms:
Windows 7 SP1 or later,
macOS 10.13 (High Sierra) or later, iOS, etc.,
Linux distributions (specific dependencies required, see the list of Linux distributions supported by .NET 6 for details),
Android (Android 5.0 (API 21) or later).

References
----------
[1] https://github.com/FireRedTeam/FireRedASR
[2] https://github.com/FireRedTeam/FireRedASR2S