// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiWeasyl : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M21.23 4.156a8.488 8.488 0 0 0-5.871-1.857c-3.766.243-6.324 2.662-7.364 6.481-1.28-1.224-1.892-3.238-2.093-5.54-1.02.215-1.658.702-2.233 1.237.445 2.316 1.802 4.015 3.264 5.158-2.559.317-5.99 2.442-6.771 4.904-.507 1.598.258 3.415 1.283 4.52 1.237 1.333 3.75 1.998 6.355 1.754.037.362-.104.536-.058.907 4.067-.306 7.174-1.646 10.04-3.894 1.119-.877 2.659-2.037 3.756-3.227 1.101-1.192 2.296-2.578 2.443-4.52.21-2.79-1.236-4.694-2.751-5.923zm-1.434 10.938c-1.035 1.001-2.241 1.797-3.351 2.675-1.249-1.987-2.583-3.984-3.887-5.917.017 2.63.006 5.432.04 7.957-.78.381-1.789.558-2.744.763-1.935-2.917-3.968-5.99-5.961-8.908.693-.447 1.627-.785 2.478-1.075 1.419 2.05 2.729 4.253 4.171 6.333.019-3.113-.009-6.673-.061-9.919a14.175 14.175 0 0 0 1.527-.434c1.813 2.721 3.553 5.628 5.464 8.359a547.35 547.35 0 0 1-.018-9.768c.858-.282 1.803-.535 2.669-.809.02 3.499-.338 7.128-.327 10.743z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
