// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiUsaFlag : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 18v29h238V18H256zm-208 .002l-9.404 19.053-21.03 3.056 15.217 14.833L29.19 75.89l18.812-9.892 18.807 9.89-3.593-20.945L78.434 40.11l-21.032-3.055L48 18.002zm80 0l-9.404 19.053-21.032 3.056 15.217 14.833-3.59 20.946L128 65.997l18.807 9.89-3.592-20.945 15.217-14.832-21.03-3.055L128 18.002zm80 0l-9.404 19.053-21.032 3.056 15.217 14.833-3.59 20.946L208 65.997l18.807 9.89-3.592-20.945 15.217-14.832-21.03-3.055L208 18.002zm-39.404 54.385L159.19 91.44l-21.028 3.056 15.217 14.832-3.593 20.945 18.81-9.89 18.807 9.89-3.59-20.945 15.215-14.832-21.032-3.057-9.402-19.053zm-79.998 1.998L79.193 93.44l-21.03 3.056 15.218 14.832-3.593 20.945 18.81-9.89 18.807 9.89-3.59-20.945 15.215-14.832L98 93.44l-9.402-19.055zM256 81v30h238V81H256zM48 130.004l-9.404 19.053-21.03 3.056 15.217 14.832-3.592 20.946L48.003 178l18.807 9.89-3.593-20.945 15.217-14.832-21.032-3.056L48 130.004zm80 0l-9.404 19.053-21.032 3.056 15.217 14.832-3.59 20.946L128 178l18.807 9.89-3.592-20.945 15.217-14.832-21.03-3.056L128 130.004zm80 0l-9.404 19.053-21.032 3.056 15.217 14.832-3.59 20.946L208 178l18.807 9.89-3.592-20.945 15.217-14.832-21.03-3.056L208 130.004zM256 145v30h238v-30H256zM88.598 186.385l-9.405 19.054-21.03 3.056 15.218 14.832-3.593 20.945 18.81-9.89 18.807 9.89-3.59-20.945 15.215-14.832L98 205.44l-9.402-19.055zm79.998.002l-9.405 19.052-21.028 3.056 15.217 14.832-3.593 20.945 18.81-9.89 18.807 9.89-3.59-20.945 15.215-14.832-21.032-3.057-9.402-19.053zM256 209v30h238v-30H256zM18 273v30h476v-30H18zm0 64v30h476v-30H18zm0 64v30h476v-30H18zm0 64v29h476v-29H18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
