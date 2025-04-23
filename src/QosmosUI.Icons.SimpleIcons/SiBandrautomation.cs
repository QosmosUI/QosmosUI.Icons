// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiBandrautomation : ComponentBase
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
		builder.AddAttribute(15, "d", "M24 16.444H0v2.088h24v-2.088Zm-8.812-1.59-1.418-1.766.623-.767-.831-1.036-.623.767-1.565-1.959 2.192.008V8.592H9.39v1.405l.667.835c-.072.036-.538.245-.691.349-.442.27-.775.688-.939 1.18a2.052 2.052 0 0 0 1.04 2.349c.823.417 1.931.333 2.758-.04.168-.081.333-.177.482-.289l.124-.093.458.566h1.899ZM6.179 9.989a2.11 2.11 0 0 0 1.204-1.984c0-1.541-1.116-2.537-2.991-2.537H0v9.39h4.549c2.111 0 3.123-1.216 3.123-2.629a2.256 2.256 0 0 0-1.489-2.24h-.004Zm15.035 1.401s2.132-.442 2.132-2.931c0-1.75-1.076-2.991-3.252-2.991h-4.445v9.39h2.092V11.39h1.004l2.778 3.468h2.473L21.21 11.39h.004Zm-11.073 1.911a.713.713 0 0 1-.044-.831c.209-.261.482-.466.795-.59l1.072 1.353c-.213.14-.434.26-.667.365a1.15 1.15 0 0 1-.975-.133.91.91 0 0 1-.177-.168l-.004.004Zm-5.837-.008H2.088v-2.61h2.256c.911 0 1.453.45 1.453 1.305 0 .803-.518 1.305-1.493 1.305ZM17.745 9.78V7.259h2.212c.92 0 1.494.385 1.494 1.26 0 .799-.538 1.261-1.494 1.261h-2.212ZM2.088 7.062h2.007c.763 0 1.216.401 1.216 1.116 0 .715-.453 1.168-1.32 1.168H2.088V7.062Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
