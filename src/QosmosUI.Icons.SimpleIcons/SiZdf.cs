// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiZdf : ComponentBase
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
		builder.AddAttribute(15, "d", "M7.014 4.987A7.02 7.02 0 000 12.005a7.017 7.017 0 0013.271 3.174h2.915c.696 0 1.324-.044 1.962-.553.461-.365.749-.884.883-1.56v2.103h1.336v-2.473h3.153v-1.1h-3.16l.02-.445c.005-.724.226-1.162 1.277-1.162H24V8.876h-2.818c-1.517 0-2.141.85-2.141 2.18v.129c-.254-1.565-1.185-2.31-2.889-2.31h-2.855a7.018 7.018 0 00-6.283-3.888zM8.02 8.876h3.436c1.742 0 1.992 1.219 1.992 1.9 0 .725-.298 1.873-1.992 1.873h-.844c-1.056 0-1.281.38-1.281 1.104v.336h3.945v1.074H7.982v-1.558c0-1.335.625-2.123 2.137-2.123h.873c.691 0 1.1-.14 1.1-.725 0-.605-.409-.772-1.12-.772h-2.95v-1.11zm6.63 1.113h1.472c1.157 0 1.574.496 1.574 2.04 0 1.542-.412 2.036-1.574 2.036H14.65z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
