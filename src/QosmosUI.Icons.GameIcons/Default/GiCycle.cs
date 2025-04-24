// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiCycle : ComponentBase
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
		builder.AddAttribute(14, "d", "M252.314 19.957c-72.036.363-142.99 33.534-189.18 95.97-69.83 94.39-59.125 223.32 19.85 304.993l-37.238 50.332 151.22-22.613L174.35 297.42l-43.137 58.308c-44.08-54.382-47.723-133.646-4.16-192.53 30.676-41.466 77.863-63.504 125.758-63.753 16.344-.085 32.766 2.382 48.645 7.467l-6.963-46.55c-23.858-4.86-47.908-5.026-71.017-.997-59.232 7.322-113.994 39.918-148.157 91.215 35.65-65.89 103.774-105.918 176.043-107.744 1.673-.042 3.347-.063 5.023-.065 14.8-.01 29.748 1.596 44.597 4.905l48.608-7.268c-31.14-13.906-64.32-20.62-97.274-20.453zm212.93 22.055l-151.217 22.61 22.614 151.22 41.126-55.588c42.204 54.29 45.092 132.048 2.187 190.043-40.22 54.367-108.82 75.32-170.19 57.566l6.522 43.598c28.726 5.533 58.236 4.414 86.203-3.07 37.448-5.957 73.34-22.05 103.16-47.728-49.196 54.65-122.615 77.514-191.744 64.34l-55.8 8.344c99.03 43.7 218.402 14.77 285.51-75.938 69.13-93.445 59.34-220.743-17.483-302.53l39.114-52.866z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
