// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiDropletSplash : ComponentBase
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
		builder.AddAttribute(14, "d", "M247.563 19.813c-13.458 0-24.344 10.917-24.344 24.375 0 13.457 10.885 24.343 24.343 24.343 13.457 0 24.375-10.888 24.375-24.343 0-13.454-10.918-24.374-24.375-24.374zm.937 70.312c-4.414 85.037-23.308 149.063-46.156 149.063-5.667 0-11.307-4.22-16.344-11.438 1.29 41.965-4.895 68.787-19.844 67.625-5.412-.42-11.71-4.443-18.125-11.406 20.254 50.4 58.82 84.75 103.376 84.75 44.556 0 83.122-34.35 103.375-84.75-6.413 6.962-12.678 10.985-18.092 11.405-16.276 1.265-22.873-29.93-19.875-78.563-6.6 13.806-14.202 22.375-22.188 22.375-22.85 0-41.71-64.025-46.125-149.062zM104.25 314.53c-51.466 16.677-84.688 41.948-84.688 69.97 0 50.166 104.813 91.096 234.188 91.094 129.375-.002 234.188-40.928 234.188-91.094 0-28.02-33.222-53.293-84.688-69.97 27.147 12.92 43.813 29.24 43.813 47.19 0 41.413-86.506 74.81-193.313 74.81-106.805.002-193.313-33.397-193.313-74.81 0-17.95 16.666-34.273 43.813-47.19zm68.906 13.814c-28.25 9.053-46.72 22.128-46.72 37.437 0 27.24 57.065 49.626 127.314 49.626 70.248 0 127.313-22.386 127.313-49.625 0-15.308-18.468-28.383-46.72-37.436 14.94 7.036 24.532 15.4 24.532 25.22 0 22.485-47.132 40.686-105.125 40.686s-105.125-18.2-105.125-40.688c0-9.818 9.592-18.182 24.53-25.218z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
