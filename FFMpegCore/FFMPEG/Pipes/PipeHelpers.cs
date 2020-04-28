﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FFMpegCore.FFMPEG.Pipes
{
    static class PipeHelpers
    {
        public static string GetUnqiuePipeName() => "FFMpegCore_Pipe_" + Guid.NewGuid();

        public static string GetPipePath(string pipeName)
        {
            return $@"\\.\pipe\{pipeName}";
        }
    }
}
