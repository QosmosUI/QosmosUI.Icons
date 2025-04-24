// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiHighTide : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M40 24v464h80v-32H80v-16h40v-48H80v-16h40v-48H80v-16h40v-48H80v-16h40v-48H80v-16h40v-48H80v-16h40V72H80V56h40V24H40zm152 8c-15.503 0-31.65 8.898-45.133 17.184A256.9 256.9 0 0 0 136 56.268V75.96c3.741-2.82 10.696-7.891 19.244-13.145C167.8 55.102 183.652 48 192 48c8.348 0 16.977 6.256 27.014 14.256C229.05 70.256 240.497 80 256 80c15.503 0 26.95-9.744 36.986-17.744C303.023 54.256 311.652 48 320 48c8.348 0 16.977 6.256 27.014 14.256C357.05 70.256 368.497 80 384 80c15.503 0 26.95-9.744 36.986-17.744C431.023 54.256 439.652 48 448 48c8.348 0 24.201 7.102 36.756 14.816A243.821 243.821 0 0 1 496 70.186V50.992c-.95-.603-1.88-1.202-2.867-1.808C479.65 40.898 463.503 32 448 32c-15.503 0-26.95 9.744-36.986 17.744C400.977 57.744 392.348 64 384 64c-8.348 0-16.977-6.256-27.014-14.256C346.95 41.744 335.503 32 320 32c-15.503 0-26.95 9.744-36.986 17.744C272.977 57.744 264.348 64 256 64c-8.348 0-16.977-6.256-27.014-14.256C218.95 41.744 207.503 32 192 32zm0 48c-15.503 0-31.65 8.898-45.133 17.184A256.9 256.9 0 0 0 136 104.268v19.693c3.741-2.82 10.696-7.891 19.244-13.145C167.8 103.102 183.652 96 192 96c8.348 0 16.977 6.256 27.014 14.256C229.05 118.256 240.497 128 256 128c15.503 0 26.95-9.744 36.986-17.744C303.023 102.256 311.652 96 320 96c8.348 0 16.977 6.256 27.014 14.256C357.05 118.256 368.497 128 384 128c15.503 0 26.95-9.744 36.986-17.744C431.023 102.256 439.652 96 448 96c8.348 0 24.201 7.102 36.756 14.816a243.821 243.821 0 0 1 11.244 7.37V98.992c-.95-.603-1.88-1.202-2.867-1.808C479.65 88.898 463.503 80 448 80c-15.503 0-26.95 9.744-36.986 17.744C400.977 105.744 392.348 112 384 112c-8.348 0-16.977-6.256-27.014-14.256C346.95 89.744 335.503 80 320 80c-15.503 0-26.95 9.744-36.986 17.744C272.977 105.744 264.348 112 256 112c-8.348 0-16.977-6.256-27.014-14.256C218.95 89.744 207.503 80 192 80z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
