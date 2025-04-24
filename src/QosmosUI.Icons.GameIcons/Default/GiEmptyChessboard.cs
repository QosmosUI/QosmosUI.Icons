// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiEmptyChessboard : ComponentBase
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
		builder.AddAttribute(14, "d", "M21 21v58.75h58.75V21H21zm58.75 58.75v58.75h58.75V79.75H79.75zm58.75 0h58.75V21H138.5v58.75zm58.75 0v58.75H256V79.75h-58.75zm58.75 0h58.75V21H256v58.75zm58.75 0v58.75h58.75V79.75h-58.75zm58.75 0h58.75V21H373.5v58.75zm58.75 0v58.75H491V79.75h-58.75zm0 58.75H373.5v58.75h58.75V138.5zm0 58.75V256H491v-58.75h-58.75zm0 58.75H373.5v58.75h58.75V256zm0 58.75v58.75H491v-58.75h-58.75zm0 58.75H373.5v58.75h58.75V373.5zm0 58.75V491H491v-58.75h-58.75zm-58.75 0h-58.75V491h58.75v-58.75zm-58.75 0V373.5H256v58.75h58.75zm-58.75 0h-58.75V491H256v-58.75zm-58.75 0V373.5H138.5v58.75h58.75zm-58.75 0H79.75V491h58.75v-58.75zm-58.75 0V373.5H21v58.75h58.75zm0-58.75h58.75v-58.75H79.75v58.75zm0-58.75V256H21v58.75h58.75zm0-58.75h58.75v-58.75H79.75V256zm0-58.75V138.5H21v58.75h58.75zm58.75 0h58.75V138.5H138.5v58.75zm58.75 0V256H256v-58.75h-58.75zm58.75 0h58.75V138.5H256v58.75zm58.75 0V256h58.75v-58.75h-58.75zm0 58.75H256v58.75h58.75V256zm0 58.75v58.75h58.75v-58.75h-58.75zm-58.75 0h-58.75v58.75H256v-58.75zm-58.75 0V256H138.5v58.75h58.75z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
