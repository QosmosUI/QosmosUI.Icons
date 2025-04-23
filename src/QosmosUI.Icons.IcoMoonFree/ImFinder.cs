// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree;

public class ImFinder : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M8.894 12.16c-0-0.001-0-0.001-0-0.002 0 0.001 0 0.001 0 0.002z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M8.916 12.727c-0-0.004-0-0.007-0.001-0.011 0 0.004 0 0.007 0.001 0.011z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M8.903 12.442c-0-0.003-0-0.006-0-0.008 0 0.003 0 0.006 0 0.008z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M15 0h-14c-0.55 0-1 0.45-1 1v14c0 0.55 0.45 1 1 1h7.716c0.001 0 0.001 0 0.002 0s0.001-0 0.002-0h6.28c0.55 0 1-0.45 1-1v-14c0-0.55-0.45-1-1-1zM3 3.5c0-0.276 0.224-0.5 0.5-0.5s0.5 0.224 0.5 0.5v1c0 0.276-0.224 0.5-0.5 0.5s-0.5-0.224-0.5-0.5v-1zM15 15h-5.86c-0.105-0.658-0.17-1.336-0.209-1.994 0 0.002 0 0.004 0 0.005-0.308 0.034-0.618 0.051-0.931 0.051-2.088 0-4.1-0.76-5.664-2.141-0.233-0.206-0.255-0.561-0.050-0.794s0.561-0.255 0.794-0.050c1.358 1.199 3.105 1.859 4.919 1.859 0.298 0 0.595-0.018 0.888-0.053-0.034-1.847 0.107-3.311 0.11-3.334 0.014-0.141-0.032-0.28-0.127-0.385s-0.229-0.164-0.371-0.164h-1.487c0.022-0.541 0.079-1.466 0.234-2.503 0.295-1.981 0.812-3.528 1.502-4.497h6.251v14z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M12.5 5c-0.276 0-0.5-0.224-0.5-0.5v-1c0-0.276 0.224-0.5 0.5-0.5s0.5 0.224 0.5 0.5v1c0 0.276-0.224 0.5-0.5 0.5z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M8.445 13.050c-0.057 0.003-0.114 0.005-0.171 0.007 0.057-0.002 0.114-0.004 0.171-0.007z");
		builder.CloseElement();
		builder.OpenElement(25, "path");
		builder.AddAttribute(26, "d", "M8 13.063c0.073 0 0.146-0.001 0.22-0.003-0.073 0.002-0.146 0.003-0.22 0.003z");
		builder.CloseElement();
		builder.OpenElement(27, "path");
		builder.AddAttribute(28, "d", "M8.423 11.925c0.012-0.001 0.024-0.001 0.037-0.002-0.012 0.001-0.024 0.001-0.037 0.002z");
		builder.CloseElement();
		builder.OpenElement(29, "path");
		builder.AddAttribute(30, "d", "M8.204 11.934c0.017-0 0.034-0.001 0.050-0.002-0.017 0.001-0.034 0.001-0.050 0.002z");
		builder.CloseElement();
		builder.OpenElement(31, "path");
		builder.AddAttribute(32, "d", "M13.713 10.128c-0.206-0.233-0.561-0.255-0.794-0.050-1.135 1.002-2.542 1.627-4.032 1.806 0.007 0.364 0.020 0.742 0.043 1.127 1.749-0.191 3.403-0.916 4.733-2.090 0.233-0.206 0.255-0.561 0.050-0.794z");
		builder.CloseElement();
		builder.OpenElement(33, "path");
		builder.AddAttribute(34, "d", "M8.93 13.012c-0.072 0.008-0.144 0.015-0.216 0.021 0.072-0.006 0.144-0.013 0.216-0.021z");
		builder.CloseElement();
		builder.OpenElement(35, "path");
		builder.AddAttribute(36, "d", "M8.68 13.035c-0.061 0.005-0.122 0.009-0.183 0.013 0.061-0.004 0.122-0.008 0.183-0.013z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
