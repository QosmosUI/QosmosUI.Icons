// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiStunGrenade : ComponentBase
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
		builder.AddAttribute(14, "d", "M254.785 20.36c-16.934 0-32.385 4.04-44.254 11.214-11.867 7.176-20.745 18.27-20.745 31.643 0 13.372 8.878 24.467 20.746 31.642 11.87 7.175 27.32 11.214 44.255 11.214 11.424 0 22.168-1.845 31.598-5.244l-18.87 18.87L390.552 242.74l21.214-21.215-122-122c3.282-1.36 6.387-2.917 9.275-4.664 6.595-3.988 12.26-9.19 15.997-15.317l18.943 18.945-9.898 9.9 107.79 107.79 16.263-48.79-91.526-91.53-9.9 9.902-27.31-27.31c-1.817-11.24-9.933-20.57-20.36-26.876-11.87-7.175-27.32-11.215-44.255-11.215zM359.12 33.12l-9.897 9.9L468.73 162.525l-24.953 74.856-142.76 164.725 9.926 9.928L473.1 228.256l20.29-60.87L359.12 33.12zm-104.335 5.24c13.994 0 26.542 3.54 34.942 8.62 8.4 5.077 12.058 10.91 12.058 16.237 0 5.327-3.66 11.16-12.058 16.238-8.4 5.078-20.948 8.62-34.942 8.62-13.993 0-26.542-3.542-34.94-8.62-8.4-5.078-12.06-10.91-12.06-16.238 0-5.327 3.66-11.16 12.06-16.238 8.398-5.08 20.947-8.62 34.94-8.62zm0 94.068L52.55 334.66 175.59 457.7l202.232-202.233-123.037-123.04zM39.822 347.388l-21.21 21.216L141.645 491.64l21.215-21.214L39.823 347.39z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
