// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiLowTide : ComponentBase
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
		builder.AddAttribute(14, "d", "M40 24v464h80v-32H80v-16h40v-48H80v-16h40v-48H80v-16h40v-48H80v-16h40v-48H80v-16h40v-48H80v-16h40V72H80V56h40V24H40zm152 368c-15.503 0-31.65 8.898-45.133 17.184A256.9 256.9 0 0 0 136 416.268v19.693c3.741-2.82 10.696-7.891 19.244-13.145C167.8 415.102 183.652 408 192 408c8.348 0 16.977 6.256 27.014 14.256C229.05 430.256 240.497 440 256 440c15.503 0 26.95-9.744 36.986-17.744C303.023 414.256 311.652 408 320 408c8.348 0 16.977 6.256 27.014 14.256C357.05 430.256 368.497 440 384 440c15.503 0 26.95-9.744 36.986-17.744C431.023 414.256 439.652 408 448 408c8.348 0 24.201 7.102 36.756 14.816a243.821 243.821 0 0 1 11.244 7.37v-19.194c-.95-.603-1.88-1.202-2.867-1.808C479.65 400.898 463.503 392 448 392c-15.503 0-26.95 9.744-36.986 17.744C400.977 417.744 392.348 424 384 424c-8.348 0-16.977-6.256-27.014-14.256C346.95 401.744 335.503 392 320 392c-15.503 0-26.95 9.744-36.986 17.744C272.977 417.744 264.348 424 256 424c-8.348 0-16.977-6.256-27.014-14.256C218.95 401.744 207.503 392 192 392zm0 48c-15.503 0-31.65 8.898-45.133 17.184A256.9 256.9 0 0 0 136 464.268v19.693c3.741-2.82 10.696-7.891 19.244-13.145C167.8 463.102 183.652 456 192 456c8.348 0 16.977 6.256 27.014 14.256C229.05 478.256 240.497 488 256 488c15.503 0 26.95-9.744 36.986-17.744C303.023 462.256 311.652 456 320 456c8.348 0 16.977 6.256 27.014 14.256C357.05 478.256 368.497 488 384 488c15.503 0 26.95-9.744 36.986-17.744C431.023 462.256 439.652 456 448 456c8.348 0 24.201 7.102 36.756 14.816a243.821 243.821 0 0 1 11.244 7.37v-19.194c-.95-.603-1.88-1.202-2.867-1.808C479.65 448.898 463.503 440 448 440c-15.503 0-26.95 9.744-36.986 17.744C400.977 465.744 392.348 472 384 472c-8.348 0-16.977-6.256-27.014-14.256C346.95 449.744 335.503 440 320 440c-15.503 0-26.95 9.744-36.986 17.744C272.977 465.744 264.348 472 256 472c-8.348 0-16.977-6.256-27.014-14.256C218.95 449.744 207.503 440 192 440z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
