// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiLobsters : ComponentBase
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
		builder.AddAttribute(15, "d", "M0 0v24h24V0zm5.414 4.02h7.86c.105 0 .15.014.15.134-.015.285 0 .556 0 .841v.12c-.21.015-.42 0-.615.03-.3.045-.6.089-.885.164-.525.165-.793.527-.853 1.022a5.09 5.09 0 0 0-.047.674v9.586c0 .405.046.808.091 1.198.045.435.33.72.736.87.345.135.718.167 1.078.182.945.03 1.877.014 2.792-.226 1.32-.33 2.204-1.156 2.64-2.46.134-.42.193-.855.298-1.29.015-.03.046-.09.076-.09h.99c-.03 1.8.03 3.599 0 5.399H5.25v-.944c0-.165 0-.149.15-.164.344-.03.689-.045 1.034-.105.69-.12 1.005-.467 1.11-1.172.03-.21.047-.434.047-.644V7.035c0-.27-.032-.54-.062-.795-.045-.465-.344-.749-.779-.914-.405-.15-.825-.166-1.245-.196h-.226v-.976c0-.105.03-.134.135-.134z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
