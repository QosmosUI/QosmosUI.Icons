// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCurvyKnife : ComponentBase
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
		builder.AddAttribute(14, "d", "M57.656 16.156C42.71 16.533 31.24 29.793 24.5 44.813 6.05 85.91 32.88 81.803 71.156 90.374 79.272 66.585 86.96 48.042 94.72 31.53 87.197 27.1 79.315 22.944 71 19.126c-4.708-2.162-9.158-3.074-13.344-2.97zm52.907 25.5c-7.026 15.13-13.945 32.076-21.344 53.688 10.168 3.41 20.723 8.157 31.155 15.094 11.68-12.212 23.456-21.498 35.28-29.063-13.287-14.6-28.152-27.967-45.093-39.72zm57.28 53.97c-11.064 6.804-21.837 15.1-32.718 26.343 11.416 10.345 22.372 23.944 32.125 42.124 7.94-13.026 16.59-23.73 25.625-33.125-7.722-12.28-15.997-24.11-25.03-35.345zm104.876 6.655c-21.823 9.456-42.608 20.63-59.908 35.126-.123.117-.25.227-.375.344-13.47 12.74-25.593 27.446-36.28 48.72-2.3 5.677-4.237 11.678-5.72 18.03 21.49 66.477 64.75 126.913 119.5 172.094 33.212 37.003 79.484 67.087 129.47 89.03C300.828 433.35 196.2 335.897 155.124 217.563c-13.287 6.835-27.93 11.178-42.03 11.625 77.753 185.39 256.893 319.184 382.28 238.657-161.46-55.25-192.335-204.99-257.28-326.344 12.505-8.307 26.713-15.444 42.06-22.094l-7.436-17.125z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
