// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Solid;

public class BiSolidBxsFileJpg : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8l-6-6zM9.239 16.446c0 1.152-.551 1.554-1.438 1.554-.21 0-.486-.036-.665-.097l.101-.737c.127.042.289.072.469.072.384 0 .623-.174.623-.804v-2.543h.911v2.555zm3.294-.365c-.313.293-.773.426-1.313.426-.12 0-.228-.007-.312-.019v1.445h-.906v-3.988a7.528 7.528 0 0 1 1.236-.083c.563 0 .965.107 1.234.323.259.204.433.54.433.936s-.133.732-.372.96zm4.331 1.667c-.28.096-.815.228-1.349.228-.737 0-1.271-.186-1.643-.546-.371-.348-.575-.875-.57-1.469.007-1.344.983-2.111 2.309-2.111.521 0 .924.103 1.121.198l-.191.731c-.222-.096-.497-.174-.941-.174-.761 0-1.338.432-1.338 1.308 0 .833.523 1.325 1.271 1.325.211 0 .378-.024.451-.061v-.846h-.624v-.713h1.504v2.13zM14 9h-1V4l5 5h-4z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M11.285 14.552c-.186 0-.312.018-.377.036v1.193c.077.018.174.023.307.023.484 0 .784-.246.784-.659 0-.372-.257-.593-.714-.593z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
