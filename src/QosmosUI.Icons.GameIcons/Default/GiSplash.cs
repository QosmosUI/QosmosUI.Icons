// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSplash : ComponentBase
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
		builder.AddAttribute(14, "d", "M230.406 14.656c-11.74.595-21.094 10.332-21.094 22.22 0 12.27 9.948 22.187 22.22 22.187 12.27 0 22.218-9.917 22.218-22.188 0-12.27-9.948-22.22-22.22-22.22-.382 0-.745-.018-1.124 0zm119.5 75.5c-14.066 0-25.47 11.402-25.47 25.47.002 14.066 11.404 25.468 25.47 25.468 14.067 0 25.47-11.402 25.47-25.47 0-14.066-11.403-25.468-25.47-25.468zM231.594 104.25c9.608 135.475-16.43 339.177-104.03 143.063 43.005 161.424-1.16 193.905-82.158 134.375C92.892 428.228 96.6 446 93.438 490.063h87.53c6.024-134.79 170.218-112.52 160.97 0h61.593c-2.084-64.2 19.595-109.802 79.72-169.063-61.48 49.15-138.108 86.467-125.438-41.188-48.405 139.543-115.11-25.45-126.218-175.562zM390.5 163.313c-19.997 0-36.22 16.22-36.22 36.218 0 19.998 16.223 36.22 36.22 36.22s36.188-16.222 36.188-36.22c0-19.996-16.19-36.218-36.188-36.218zM49.28 304.905c-14.065 0-25.468 11.402-25.468 25.47 0 14.066 11.403 25.468 25.47 25.468 14.066 0 25.468-11.402 25.468-25.47 0-14.066-11.402-25.468-25.47-25.468z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
